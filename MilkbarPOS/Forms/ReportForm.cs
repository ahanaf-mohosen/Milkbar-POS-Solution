using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using MilkbarPOS.Data;


namespace MilkbarPOS.Forms
{
    public partial class ReportForm : Form1
    {
        private readonly string _currentUsername;
        private readonly string _currentRole;

        public ReportForm(string username, string role)
        {
            _currentUsername = username;
            _currentRole = role;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        //public ReportForm()
        //{
        //    InitializeComponent();
        //}

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadCashiers();
            LoadProducts();
            dtStart.Value = DateTime.Today.AddDays(-7); // default last 7 days
            dtEnd.Value = DateTime.Today;
            lblx.TabStop = false; // Assuming lblx is a label for closing the form
            btnGenerate.TabStop = false; // Assuming btnGenerate is the button to generate the report
            dtStart.TabStop = false; // Assuming dtStart is the DateTimePicker for start date
            dtEnd.TabStop = false; // Assuming dtEnd is the DateTimePicker for end date
            cmbCashier.TabStop = false; // Assuming cmbCashier is the ComboBox for selecting cashiers
            cmbProduct.TabStop = false; // Assuming cmbProduct is the ComboBox for selecting products
            lblMinimize.TabStop = false; // Prevents the label from being focused
        }

        private void LoadCashiers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> cashiers = new Dictionary<int, string>();
                cashiers.Add(0, "All Cashiers");

                while (reader.Read())
                {
                    cashiers.Add((int)reader["UserID"], reader["Username"].ToString());
                }

                cmbCashier.DataSource = new BindingSource(cashiers, null);
                cmbCashier.DisplayMember = "Value";
                cmbCashier.ValueMember = "Key";
            }
        }

        private void LoadProducts()
        {
            
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> products = new Dictionary<int, string>();
                products.Add(0, "All Products");

                while (reader.Read())
                {
                    products.Add((int)reader["ProductID"], reader["ProductName"].ToString());
                }

                cmbProduct.DataSource = new BindingSource(products, null);
                cmbProduct.DisplayMember = "Value";
                cmbProduct.ValueMember = "Key";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime start = dtStart.Value.Date;
            DateTime end = dtEnd.Value.Date.AddDays(1); // include end date
            int selectedCashier = ((KeyValuePair<int, string>)cmbCashier.SelectedItem).Key;
            int selectedProduct = ((KeyValuePair<int, string>)cmbProduct.SelectedItem).Key;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT 
                    T.TransactionID,
                    FORMAT(T.TransactionDate, 'yyyy-MM-dd HH:mm') AS Date,
                    U.Username AS Cashier,
                    P.ProductName AS Product,
                    TD.Quantity,
                    TD.PriceAtTime,
                    (TD.Quantity * TD.PriceAtTime) AS Total
                FROM Transactions T
                JOIN Users U ON T.UserID = U.UserID
                JOIN TransactionDetails TD ON T.TransactionID = TD.TransactionID
                JOIN Products P ON TD.ProductID = P.ProductID
                WHERE T.TransactionDate BETWEEN @start AND @end";

                if (selectedCashier > 0)
                    query += " AND U.UserID = @userID";

                if (selectedProduct > 0)
                    query += " AND P.ProductID = @productID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                if (selectedCashier > 0)
                    cmd.Parameters.AddWithValue("@userID", selectedCashier);
                if (selectedProduct > 0)
                    cmd.Parameters.AddWithValue("@productID", selectedProduct);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvReport.DataSource = table;

                dgvReport.Columns["PriceAtTime"].DefaultCellStyle.Format = "C2";
                dgvReport.Columns["Total"].DefaultCellStyle.Format = "C2";

                decimal totalSales = table.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
                lblSummary.Text = $"Total Sales: ${totalSales:F2} | Transactions: {table.Rows.Count}";
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblx_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(_currentUsername, _currentRole);
            mainForm.Show();
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}