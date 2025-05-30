using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MilkbarPOS.Data;

namespace MilkbarPOS.Forms
{
    public partial class ManageProductsForm : Form1
    {
        private int selectedProductId = -1;
        private readonly string _currentUsername;
        private readonly string _currentRole;

        //public ManageProductsForm(string username, string role)
        //{
        //    _currentUsername = username;
        //    _currentRole = role;
        //    InitializeComponent();
        //}
        public ManageProductsForm(string username, string role)
        {
            _currentUsername = username;
            _currentRole = role;
            InitializeComponent();
            LoadProducts();
            EnsureForeignKeyConstraint();

            txtProductName.KeyDown += txtProductName_KeyDown;
            txtPrice.KeyDown += txtPrice_KeyDown;

            btnAdd.TabStop = false;
            btnUpdate.TabStop = false;
            btnDelete.TabStop = false;
            dgvProducts.TabStop = false;
            txtPrice.TabStop = false;
            txtProductName.TabStop = false;
            txtStock.TabStop = false;
            lblx.TabStop = false;
            lblStatus.Visible = false; // Hide status label initially
            lblMinimize.TabStop = false; // Prevents the label from being focused


            // Add event handlers to hide status message when user interacts with controls
            txtProductName.TextChanged += HideStatusMessage;
            txtProductName.Click += HideStatusMessage;
            txtPrice.TextChanged += HideStatusMessage;
            txtPrice.Click += HideStatusMessage;
            txtStock.TextChanged += HideStatusMessage;
            txtStock.Click += HideStatusMessage;
            dgvProducts.CellClick += HideStatusMessageFromDataGrid;

            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //lblManageProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //lblManageProducts.TextAlign = ContentAlignment.MiddleRight;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrice.Focus(); 
            }
        }

        
        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtStock.Focus();
            }
        }

        // Method to hide status message
        private void HideStatusMessage(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
        }

        // Separate method for DataGridView since it has different event args
        private void HideStatusMessageFromDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Visible = false;
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }

            dgvProducts.Columns["ProductID"].Visible = false;
            dgvProducts.Columns["ProductName"].HeaderText = "Product";
            dgvProducts.Columns["Price"].HeaderText = "Price";
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "C2";
            dgvProducts.Columns["StockQuantity"].HeaderText = "Quantity";
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearInputs()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            selectedProductId = -1;
            lblStatus.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out decimal price, out int stock)) return;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, Price, StockQuantity) VALUES (@name, @price, @stock)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
            }
            LoadProducts();
            ClearInputs();
            lblStatus.Text = "✅ Product added.";
            lblStatus.Visible = true; // Show status message
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                lblStatus.Text = "⚠️ Select a product first.";
                lblStatus.Visible = true; // Show status message
                return;
            }

            if (!ValidateInputs(out string name, out decimal price, out int stock)) return;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @name, Price = @price, StockQuantity = @stock WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@id", selectedProductId);
                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            ClearInputs();
            lblStatus.Text = "✅ Product updated.";
            lblStatus.Visible = true; // Show status message
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                lblStatus.Text = "⚠️ Select a product to delete.";
                lblStatus.Visible = true; // Show status message
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", selectedProductId);
                cmd.ExecuteNonQuery();
            }
            LoadProducts();
            ClearInputs();
            lblStatus.Text = "🗑️ Product deleted.";
            lblStatus.Visible = true; // Show status message
            
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                var productIdValue = row.Cells["ProductID"].Value;

                if (productIdValue == null || productIdValue == DBNull.Value || string.IsNullOrWhiteSpace(productIdValue.ToString()))
                {
                    ClearInputs();
                    return;
                }

                selectedProductId = Convert.ToInt32(productIdValue);
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtStock.Text = row.Cells["StockQuantity"].Value?.ToString();
            }
        }

        private bool ValidateInputs(out string name, out decimal price, out int stock)
        {
            name = txtProductName.Text.Trim();
            bool valid = true;
            price = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(name))
            {
                lblStatus.Text = "❌ Product name is required.";
                lblStatus.Visible = true; // Show status message
                valid = false;
            }
            else if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                lblStatus.Text = "❌ Enter valid price.";
                lblStatus.Visible = true; // Show status message
                valid = false;
            }
            else if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                lblStatus.Text = "❌ Enter valid quantity.";
                lblStatus.Visible = true; // Show status message
                valid = false;
            }

            return valid;
        }

        private void EnsureForeignKeyConstraint()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    IF NOT EXISTS (
                        SELECT 1 FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS
                        WHERE CONSTRAINT_NAME = 'FK_Product_TransactionDetails'
                    )
                    BEGIN
                        ALTER TABLE TransactionDetails
                        ADD CONSTRAINT FK_Product_TransactionDetails
                        FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
                        ON DELETE CASCADE
                    END", conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void lblx_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(_currentUsername, _currentRole);
            mainForm.Show();
            this.Close();
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
