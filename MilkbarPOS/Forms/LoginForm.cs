using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MilkbarPOS.Data;


namespace MilkbarPOS.Forms
{
    public partial class LoginForm : Form1
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;

            lblx.TabStop = false; // Prevents the label from being focused
            lblMessage.Visible = false;
            txtUsername.Click += HideStatusMessage;
            txtPassword.Click += HideStatusMessage;
            txtPassword.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        private void HideStatusMessage(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this,
                    "Please enter both username and password",
                    "Input Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = SecurityHelper.ComputeSha256Hash(password);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Users.UserID, Users.Username, Roles.RoleName FROM Users " +
                                   "JOIN Roles ON Users.RoleID = Roles.RoleID " +
                                   "WHERE Users.Username = @username AND Users.PasswordHash = @passwordHash";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordHash", hashedPassword);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["RoleName"].ToString();
                        int userId = Convert.ToInt32(reader["UserID"]);

                        MessageBox.Show($"Login successful! Welcome, {role}");

                        this.Hide();
                        MainForm mainForm = new MainForm(username, role);
                        mainForm.Show();
                    }
                    else
                    {
                        lblMessage.Text = "Invalid username or password!";
                        lblMessage.Visible = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this,
                    "Could not connect to the database. Please check your network or database server.\n\n" +
                    "Error: " + ex.Message,
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "An unexpected error occurred.\n\n" +
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.TabStop = false;
            txtPassword.TabStop = false;
            btnLogin.TabStop = false;
            lblMessage.Text = string.Empty; // Clear any previous messages
            lblx.TabStop = false; // Prevents the label from being focused
            lblMinimize.TabStop = false; // Prevents the label from being focused
            // Set focus to the form instead of any textbox
            this.ActiveControl = null; // Removes focus from all controls

            // Set initial password character masking
            txtPassword.UseSystemPasswordChar = true; // Mask password by default
            checkBox.Checked = true;
            checkBox.Checked = false; // Ensure checkbox reflects the initial state
            this.AcceptButton = null; // Disable default Enter key behavior
        }

        private void lblx_Click(object sender, EventArgs e)
        {
            // Display a confirmation message before closing
            DialogResult result = MessageBox.Show(this,"Are you sure you want to exit?", "Exit Application",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();

                // Alternatively, if this is for a specific form:
                // this.Close();

                // If you want to exit more forcefully:
                // Environment.Exit(0);
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Corrected logic:
            // When checked (show password), set to false (no password char)
            // When unchecked (hide password), set to true (use password char)
            txtPassword.UseSystemPasswordChar = checkBox.Checked;
        }
        // Handle Enter key in Username field
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus(); // Move to password field
            }
        }

        // Handle Enter key in Password field
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick(); // Trigger login
            }
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
