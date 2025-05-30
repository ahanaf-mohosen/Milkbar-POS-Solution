using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MilkbarPOS.Data;

namespace MilkbarPOS.Forms
{
    public partial class UserControllForm : Form1
    {
        private int selectedUserId = -1;
        private readonly string _currentUsername;
        private readonly string _currentRole;

        public UserControllForm(string username, string role)
        {
            InitializeComponent();
            _currentUsername = username;
            _currentRole = role;
            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;

            // Initialize UI settings
            lblStatus.Visible = false;
            lblMinimize.TabStop = false;
            lblx.TabStop = false;
            btnAdd.TabStop = false;
            btnUpdate.TabStop = false;
            btnDelete.TabStop = false;
            dgvUserRole.TabStop = false;
            txtUsername.TabStop = false;
            txtPassword.TabStop = false;
            comboBox.TabStop = false;

            // Populate roles dropdown
            comboBox.Items.AddRange(new string[] { "Admin", "Manager", "Cashier" });

            // Wire up event handlers
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dgvUserRole.CellClick += dgvProducts_CellClick;
            dgvUserRole.CellClick += dgvUserRole_CellContentClick;
            lblx.Click += lblx_Click;
            lblMinimize.Click += lblMinimize_Click;

            // Add event handlers to hide status message when user interacts with controls
            txtUsername.TextChanged += HideStatusMessage;
            txtUsername.Click += HideStatusMessage;
            txtPassword.TextChanged += HideStatusMessage;
            txtPassword.Click += HideStatusMessage;
            comboBox.SelectedIndexChanged += HideStatusMessage;
            comboBox.Click += HideStatusMessage;
            dgvUserRole.CellClick += HideStatusMessageFromDataGrid;

            // Center align status message
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Remove form border
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                comboBox.Focus();
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

        private void UserControllForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Join Users and Roles tables to get role name
                string query = @"SELECT u.UserID, u.Username, u.PasswordHash, r.RoleName as Role 
                               FROM Users u 
                               INNER JOIN Roles r ON u.RoleID = r.RoleID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Add a column for display password (showing asterisks instead of hash)
                table.Columns.Add("DisplayPassword", typeof(string));
                foreach (DataRow row in table.Rows)
                {
                    row["DisplayPassword"] = "********"; // Show asterisks instead of actual hash
                }

                dgvUserRole.DataSource = table;

                // Configure columns
                dgvUserRole.Columns["UserID"].Visible = false;
                dgvUserRole.Columns["PasswordHash"].Visible = false; // Hide the actual hash
                dgvUserRole.Columns["Role"].HeaderText = "Role";
                dgvUserRole.Columns["Username"].HeaderText = "Username";
                dgvUserRole.Columns["DisplayPassword"].HeaderText = "Password";
                dgvUserRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserRole.AllowUserToAddRows = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string username, out string password, out string role)) return;

            try
            {
                // Check if username already exists
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check for duplicate username
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        lblStatus.Text = "❌ Username already exists.";
                        lblStatus.Visible = true;
                        return;
                    }

                    // Get RoleID
                    SqlCommand roleCmd = new SqlCommand("SELECT RoleID FROM Roles WHERE RoleName = @role", conn);
                    roleCmd.Parameters.AddWithValue("@role", role);
                    object roleIdObj = roleCmd.ExecuteScalar();

                    if (roleIdObj == null)
                    {
                        lblStatus.Text = "❌ Invalid role selected.";
                        lblStatus.Visible = true;
                        return;
                    }

                    int roleId = (int)roleIdObj;

                    // Hash the password
                    string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

                    // Insert new user
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash, RoleID) VALUES (@username, @password, @roleId)", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
                ClearInputs();
                lblStatus.Text = "✅ User added successfully.";
                lblStatus.Visible = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Error adding user: " + ex.Message;
                lblStatus.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                lblStatus.Text = "⚠️ Select a user first.";
                lblStatus.Visible = true;
                return;
            }

            if (!ValidateInputs(out string username, out string password, out string role)) return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if username already exists for other users
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND UserID != @userId", conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@userId", selectedUserId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        lblStatus.Text = "❌ Username already exists.";
                        lblStatus.Visible = true;
                        return;
                    }

                    // Get RoleID
                    SqlCommand roleCmd = new SqlCommand("SELECT RoleID FROM Roles WHERE RoleName = @role", conn);
                    roleCmd.Parameters.AddWithValue("@role", role);
                    object roleIdObj = roleCmd.ExecuteScalar();

                    if (roleIdObj == null)
                    {
                        lblStatus.Text = "❌ Invalid role selected.";
                        lblStatus.Visible = true;
                        return;
                    }

                    int roleId = (int)roleIdObj;

                    // Hash the password
                    string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

                    // Update user
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Username = @username, PasswordHash = @password, RoleID = @roleId WHERE UserID = @userId", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);
                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
                ClearInputs();
                lblStatus.Text = "✅ User updated successfully.";
                lblStatus.Visible = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Error updating user: " + ex.Message;
                lblStatus.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                lblStatus.Text = "⚠️ Select a user to delete.";
                lblStatus.Visible = true;
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if user has any transactions
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Transactions WHERE UserID = @userId", conn);
                    checkCmd.Parameters.AddWithValue("@userId", selectedUserId);
                    int transactionCount = (int)checkCmd.ExecuteScalar();

                    if (transactionCount > 0)
                    {
                        var confirmWithTransactions = MessageBox.Show(
                            "This user has transaction history. Deleting will remove all associated transactions. Continue?",
                            "Confirm Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmWithTransactions != DialogResult.Yes) return;

                        // Delete transaction details first
                        SqlCommand deleteDetailsCmd = new SqlCommand(@"
                            DELETE td FROM TransactionDetails td 
                            INNER JOIN Transactions t ON td.TransactionID = t.TransactionID 
                            WHERE t.UserID = @userId", conn);
                        deleteDetailsCmd.Parameters.AddWithValue("@userId", selectedUserId);
                        deleteDetailsCmd.ExecuteNonQuery();

                        // Delete transactions
                        SqlCommand deleteTransCmd = new SqlCommand("DELETE FROM Transactions WHERE UserID = @userId", conn);
                        deleteTransCmd.Parameters.AddWithValue("@userId", selectedUserId);
                        deleteTransCmd.ExecuteNonQuery();
                    }

                    // Delete user
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @userId", conn);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);
                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
                ClearInputs();
                lblStatus.Text = "🗑️ User deleted successfully.";
                lblStatus.Visible = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Error deleting user: " + ex.Message;
                lblStatus.Visible = true;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool ValidateInputs(out string username, out string password, out string role)
        {
            username = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();
            role = comboBox.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(role))
            {
                lblStatus.Text = "❌ Role is required.";
                lblStatus.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                lblStatus.Text = "❌ Username is required.";
                lblStatus.Visible = true;
                return false;
            }
            if (username.Length < 3)
            {
                lblStatus.Text = "❌ Username must be at least 3 characters.";
                lblStatus.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "❌ Password is required.";
                lblStatus.Visible = true;
                return false;
            }
            if (password.Length < 4)
            {
                lblStatus.Text = "❌ Password must be at least 4 characters.";
                lblStatus.Visible = true;
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            comboBox.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            selectedUserId = -1;
            lblStatus.Text = "";
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

        private void dgvUserRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUserRole.Rows[e.RowIndex];
                if (row.Cells["UserID"].Value != DBNull.Value)
                {
                    selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                    comboBox.SelectedItem = row.Cells["Role"].Value.ToString();
                    txtUsername.Text = row.Cells["Username"].Value.ToString();
                    // Don't populate password field for security - leave it empty
                    txtPassword.Text = "";
                }
                else
                {
                    selectedUserId = -1;
                }
            }
        }
    }
}