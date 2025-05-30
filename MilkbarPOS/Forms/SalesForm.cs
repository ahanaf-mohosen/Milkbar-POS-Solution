using MilkbarPOS.Data;
using MilkbarPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MilkbarPOS.Forms
{
    public partial class SalesForm : Form1
    {
        //private string username;
        private readonly string _currentUsername;
        private readonly string _currentRole;
        private List<CartItem> cart = new List<CartItem>();

        //public SalesForm(string username, string role)
        //{
        //    _currentUsername = username;
        //    _currentRole = role;
        //    InitializeComponent();
        //}
        public SalesForm(string username, string role)
        {
            InitializeComponent();
            //username = currentUser;
            _currentUsername = username;
            _currentRole = role;

            LoadProducts();
            nudQuantity.Minimum = 1;
            // Set maximum length for discount input
            txtDiscount.MaxLength = 3; // Allows "100"
            cmbProducts.TabStop = false; // Disable tab stop for ComboBox
            nudQuantity.TabStop = false; // Disable tab stop for NumericUpDown
            txtDiscount.TabStop = false; // Disable tab stop for TextBox
            btnAddToCart.TabStop = false; // Disable tab stop for Button
            btnCheckout.TabStop = false; // Disable tab stop for Button
            lblMinimize.TabStop = false; // Prevents the label from being focused

            // Add these event handlers
            cmbProducts.Click += HideStatusMessage;
            nudQuantity.Click += HideStatusMessage;
            cmbProducts.SelectedIndexChanged += HideStatusMessage;
            nudQuantity.ValueChanged += HideStatusMessage;
            txtDiscount.TextChanged += HideStatusMessage;

            // Add event handlers
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;

            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.TextAlign = HorizontalAlignment.Center;

            
            nudQuantity.Minimum = -100; // Allow negative for decreasing quantity
            nudQuantity.Maximum = 100;  // Reasonable upper limit
            nudQuantity.Value = 1;      // Default to positive 1

            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSalesModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.FormBorderStyle = FormBorderStyle.None;
        }
        // Add this new method
        private void HideStatusMessage(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
        }

        #region Old LoadProducts Method
        /*
        private void LoadProducts()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> products = new Dictionary<int, string>();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = reader["ProductName"].ToString();
                    products.Add(id, name);
                }

                cmbProducts.DataSource = new BindingSource(products, null);
                cmbProducts.DisplayMember = "Value";
                cmbProducts.ValueMember = "Key";
            }
        }
        */
        #endregion
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> products = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ProductID"]);
                        string name = reader["ProductName"].ToString();
                        products.Add(id, name);
                    }

                    // Add default empty item
                    products.Add(-1, "-- Select Product --");

                    // Data binding with error handling
                    try
                    {
                        cmbProducts.DataSource = new BindingSource(products, null);
                        cmbProducts.DisplayMember = "Value";
                        cmbProducts.ValueMember = "Key";
                        cmbProducts.SelectedValue = -1; // Select the default item
                    }
                    catch (Exception bindEx)
                    {
                        lblStatus.Text = "⚠️ Error loading product list!";
                        lblStatus.Visible = true;
                        Debug.WriteLine($"Data binding error: {bindEx.Message}");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                lblStatus.Text = "⚠️ Database error loading products!";
                lblStatus.Visible = true;
                Debug.WriteLine($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                lblStatus.Text = "⚠️ Error loading products!";
                lblStatus.Visible = true;
                Debug.WriteLine($"General Error: {ex.Message}");
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuantity.Value > 0)
            {
                nudQuantity.ForeColor = Color.Green;
            }
            else if (nudQuantity.Value < 0)
            {
                nudQuantity.ForeColor = Color.Red;
            }
            else
            {
                nudQuantity.ForeColor = SystemColors.WindowText;
            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // First check if an item is selected
            if (cmbProducts.SelectedItem == null || (int)cmbProducts.SelectedValue == -1)
            {
                lblStatus.Text = "❌ Please select a product first!";
                lblStatus.Visible = true;
                return;
            }
            // Usage in btnAddToCart_Click://///////////
            //if (!TryGetSelectedProduct(out int productId, out string productName))
            //{
            //    lblStatus.Text = "❌ Please select a valid product!";
            //    lblStatus.Visible = true;
            //    return;
            //}
            /////////////////////
            //int productId = ((KeyValuePair<int, string>)cmbProducts.SelectedItem).Key;
            //string productName = ((KeyValuePair<int, string>)cmbProducts.SelectedItem).Value;
            //int quantity = (int)nudQuantity.Value;
            ////////////////////////////
            ///
            int productId = (int)cmbProducts.SelectedValue;
            string productName = cmbProducts.Text;
            int quantityChange = (int)nudQuantity.Value; // Can be positive or negative

            // Check if product already exists in cart
            CartItem existingItem = cart.FirstOrDefault(item => item.ProductID == productId);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Price, StockQuantity FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", productId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    int stock = Convert.ToInt32(reader["StockQuantity"]);
                    // Calculate new quantity
                    int newQuantity = existingItem != null ? existingItem.Quantity + quantityChange : quantityChange;

                    // Validate stock
                    if (newQuantity > stock)
                    {
                        lblStatus.Text = "❌ Not enough stock available!";
                        lblStatus.Visible = true; // Show only when needed
                        return;
                    }
                    string statusMessage = ""; // Store the message to show after RefreshCart
                    // Remove if quantity zero or negative
                    if (newQuantity <= 0)
                    {
                        if (existingItem != null)
                        {
                            cart.Remove(existingItem);
                            statusMessage = "🗑️ Product removed from cart.";
                        }
                        else
                        {
                            statusMessage = "❌ Invalid quantity!";
                        }
                    }
                    else
                    {
                        // Update or add item
                        if (existingItem != null)
                        {
                            existingItem.Quantity = newQuantity;
                            statusMessage = $"🔄 Quantity updated to {newQuantity}";
                        }
                        else
                        {
                            cart.Add(new CartItem
                            {
                                ProductID = productId,
                                ProductName = productName,
                                Quantity = newQuantity,
                                Price = price
                            });
                            statusMessage = "✅ Product added to cart.";
                        }
                    }
                    //cart.Add(new CartItem { ProductID = productId, ProductName = productName, Quantity = quantity, Price = price });
                    
                    //lblStatus.Text = "✅ Product added to cart.";
                    //lblStatus.Visible = true; // Show only when needed
                    nudQuantity.Value = 1;
                    RefreshCart();
                    // Show the status message AFTER RefreshCart
                    lblStatus.Text = statusMessage;
                    lblStatus.Visible = true;
                    // Force UI update
                    lblStatus.Refresh();
                    Application.DoEvents(); // Ensure message is displayed
                }
            }
        }

        // Safe way to get selected product
        private bool TryGetSelectedProduct(out int productId, out string productName)
        {
            productId = 0;
            productName = string.Empty;

            if (cmbProducts.SelectedItem == null)
                return false;

            try
            {
                var selected = (KeyValuePair<int, string>)cmbProducts.SelectedItem;
                productId = selected.Key;
                productName = selected.Value;
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart.Select(c => new
            {
                c.ProductName,
                c.Quantity,
                UnitPrice = c.Price,
                Total = c.Price * c.Quantity
            }).ToList();

            decimal subtotal = cart.Sum(c => c.Price * c.Quantity);
            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";

            decimal discount = 0;
            decimal.TryParse(txtDiscount.Text, out discount);
            decimal total = subtotal - (subtotal * discount / 100);
            lblTotal.Text = $"Total After Discount: ${total:F2}";
            //lblStatus.Visible = false; // Hide status message after refreshing cart
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                lblStatus.Text = "❌ Cart is empty!";
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    decimal total = cart.Sum(c => c.Price * c.Quantity);
                    decimal.TryParse(txtDiscount.Text, out decimal discount);
                    total -= total * discount / 100;

                    SqlCommand userCmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @username", conn, transaction);
                    userCmd.Parameters.AddWithValue("@username", _currentUsername);
                    int userId = (int)userCmd.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Transactions (UserID, TotalAmount) OUTPUT INSERTED.TransactionID VALUES (@userID, @total)", conn, transaction);
                    cmd.Parameters.AddWithValue("@userID", userId);
                    cmd.Parameters.AddWithValue("@total", total);
                    int transactionID = (int)cmd.ExecuteScalar();

                    foreach (var item in cart)
                    {
                        SqlCommand detailCmd = new SqlCommand("INSERT INTO TransactionDetails (TransactionID, ProductID, Quantity, PriceAtTime) VALUES (@tid, @pid, @qty, @price)", conn, transaction);
                        detailCmd.Parameters.AddWithValue("@tid", transactionID);
                        detailCmd.Parameters.AddWithValue("@pid", item.ProductID);
                        detailCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        detailCmd.Parameters.AddWithValue("@price", item.Price);
                        detailCmd.ExecuteNonQuery();

                        SqlCommand stockCmd = new SqlCommand("UPDATE Products SET StockQuantity = StockQuantity - @qty WHERE ProductID = @pid", conn, transaction);
                        stockCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        stockCmd.Parameters.AddWithValue("@pid", item.ProductID);
                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    cart.Clear();
                    RefreshCart();
                    lblStatus.Text = "✅ Checkout successful!";
                    lblStatus.Visible = true; // Show only when needed
                }
                catch
                {
                    transaction.Rollback();
                    lblStatus.Text = "❌ Error during checkout. Try again.";
                    lblStatus.Visible = true; // Show only when needed
                }
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Visible = false;

            // Skip if empty
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                RefreshCart();
                return;
            }

            // Validate input
            if (!decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                lblStatus.Text = "❌ Discount must be a number!";
                lblStatus.Visible = true;
                txtDiscount.Text = ""; // Clear invalid input
                RefreshCart();
                return;
            }

            // Validate range
            if (discount < 0)
            {
                lblStatus.Text = "❌ Discount cannot be negative!";
                lblStatus.Visible = true;
                txtDiscount.Text = "0";
                discount = 0;
            }
            else if (discount > 100)
            {
                lblStatus.Text = "❌ Discount cannot exceed 100%!";
                lblStatus.Visible = true;
                txtDiscount.Text = "100";
                discount = 100;
            }

            RefreshCart();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                // Show instant feedback
                lblStatus.Text = "❌ Numbers only (0-100)!";
                lblStatus.Visible = true;
            }

            // Block negative sign explicitly
            if (e.KeyChar == '-')
            {
                e.Handled = true;
                lblStatus.Text = "❌ No negative numbers!";
                lblStatus.Visible = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lblx_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(_currentUsername, _currentRole);
            mainForm.Show();
            this.Close();
        }

        private void lblSalesModule_Click(object sender, EventArgs e)
        {

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
