using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MilkbarPOS.Forms
{
    public partial class MainForm : Form1
    {
        private string currentUsername;
        private string currentRole;

        public MainForm(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Height = 40;
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            labelDashBoard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDashBoard.TextAlign = ContentAlignment.MiddleRight;

            btnSales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManageProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDashBoard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSales.TextAlign = ContentAlignment.MiddleRight;
            btnManageProducts.TextAlign = ContentAlignment.MiddleRight;
            btnReports.TextAlign = ContentAlignment.MiddleRight;
            labelDashBoard.TextAlign = ContentAlignment.MiddleRight;
            this.FormBorderStyle = FormBorderStyle.None;
            lblMinimize.TabStop = false; // Prevents the label from being focused


            lblWelcome.Text = $"Welcome, {username} ({role})";

            // Hide features for Cashiers
            if (role == "Cashier")
            {
                btnManageProducts.Visible = false;
                btnUserCotroll.Visible = false;
                //btnReports.Visible = false;
                panelMenuDashboard.ClientSize = new Size(panelMenuDashboard.ClientSize.Width, panelMenuDashboard.ClientSize.Height - btnReports.Height - 90); // Adjust the height of the panel to remove the Reports button
            }
            if (role == "Manager")
            {
                //btnManageProducts.Visible = false;
                btnUserCotroll.Visible = false;
                //btnReports.Visible = false;
                panelMenuDashboard.ClientSize = new Size(panelMenuDashboard.ClientSize.Width, panelMenuDashboard.ClientSize.Height - btnReports.Height - 10); // Adjust the height of the panel to remove the Reports button
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Center horizontally at the top (with 10px top margin)
            lblWelcome.Location = new Point(
                (this.ClientSize.Width - lblWelcome.Width) / 2,
                55
            );
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            btnLogout.TabStop = false;
            btnSales.TabStop = false;
            btnManageProducts.TabStop = false;
            btnReports.TabStop = false;
            lblx.TabStop = false; // Assuming lblx is a label for closing the form
            lblMinimize.TabStop = false; // Assuming lblMinimize is a label for minimizing the form
            lblWelcome.TabStop = false; // Prevents the label from being focused
            btnUserCotroll.TabStop = false; // Assuming btnUserCotroll is a button for user control management
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(currentUsername, currentRole);
            salesForm.Show();
            this.Close();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm manageForm = new ManageProductsForm(currentUsername, currentRole);
            manageForm.Show();
            this.Close();
        }
        private void btnUserCotroll_Click(object sender, EventArgs e)
        {
            UserControllForm userControl = new UserControllForm(currentUsername, currentRole);
            userControl.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(currentUsername, currentRole);
            reportForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = MessageBox.Show(this, "Are you sure you want to Logout?", "Logout",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            loginForm.Show();
            this.Close(); // Or redirect to login form
        }


        private void lblx_Click_1(object sender, EventArgs e)
        {
            // Display a confirmation message before closing
            DialogResult result = MessageBox.Show(this, "Are you sure you want to exit?", "Exit Application",
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

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            lblWelcome.Left = (this.ClientSize.Width - lblWelcome.Width) / 2;
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
