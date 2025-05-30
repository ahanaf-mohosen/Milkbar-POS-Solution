namespace MilkbarPOS.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.labelDashBoard = new System.Windows.Forms.Label();
            this.panelMenuDashboard = new System.Windows.Forms.Panel();
            this.btnUserCotroll = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.panelMenuDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWelcome.Location = new System.Drawing.Point(306, 68);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(270, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "[Empty initially]";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(99)))), ((int)(((byte)(30)))));
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(124, 31);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 39, 0);
            this.btnSales.Size = new System.Drawing.Size(250, 87);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales Module";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProducts.Image")));
            this.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.Location = new System.Drawing.Point(124, 232);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnManageProducts.Size = new System.Drawing.Size(250, 87);
            this.btnManageProducts.TabIndex = 2;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageProducts.UseVisualStyleBackColor = false;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(124, 133);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 70, 0);
            this.btnReports.Size = new System.Drawing.Size(250, 87);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(756, 124);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(7, 0, 5, 0);
            this.btnLogout.Size = new System.Drawing.Size(144, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblx
            // 
            this.lblx.BackColor = System.Drawing.Color.Red;
            this.lblx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx.Location = new System.Drawing.Point(-1, -1);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(38, 41);
            this.lblx.TabIndex = 10;
            this.lblx.Text = "X";
            this.lblx.UseVisualStyleBackColor = false;
            this.lblx.Click += new System.EventHandler(this.lblx_Click_1);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.lblMinimize);
            this.toppanel.Controls.Add(this.lblx);
            this.toppanel.Controls.Add(this.lblWelcome);
            this.toppanel.Controls.Add(this.btnLogout);
            this.toppanel.Location = new System.Drawing.Point(-1, -2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(901, 171);
            this.toppanel.TabIndex = 11;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toppanel_Paint);
            // 
            // lblMinimize
            // 
            this.lblMinimize.BackColor = System.Drawing.Color.DarkGray;
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinimize.Location = new System.Drawing.Point(34, -1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(38, 41);
            this.lblMinimize.TabIndex = 14;
            this.lblMinimize.Text = "--";
            this.lblMinimize.UseVisualStyleBackColor = false;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // labelDashBoard
            // 
            this.labelDashBoard.AutoSize = true;
            this.labelDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashBoard.Location = new System.Drawing.Point(259, 184);
            this.labelDashBoard.Name = "labelDashBoard";
            this.labelDashBoard.Size = new System.Drawing.Size(409, 69);
            this.labelDashBoard.TabIndex = 12;
            this.labelDashBoard.Text = "DASHBOARD";
            this.labelDashBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenuDashboard
            // 
            this.panelMenuDashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenuDashboard.Controls.Add(this.btnUserCotroll);
            this.panelMenuDashboard.Controls.Add(this.btnSales);
            this.panelMenuDashboard.Controls.Add(this.btnReports);
            this.panelMenuDashboard.Controls.Add(this.btnManageProducts);
            this.panelMenuDashboard.Location = new System.Drawing.Point(209, 261);
            this.panelMenuDashboard.Name = "panelMenuDashboard";
            this.panelMenuDashboard.Size = new System.Drawing.Size(500, 451);
            this.panelMenuDashboard.TabIndex = 13;
            // 
            // btnUserCotroll
            // 
            this.btnUserCotroll.BackColor = System.Drawing.Color.Cyan;
            this.btnUserCotroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCotroll.Image = ((System.Drawing.Image)(resources.GetObject("btnUserCotroll.Image")));
            this.btnUserCotroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCotroll.Location = new System.Drawing.Point(124, 333);
            this.btnUserCotroll.Name = "btnUserCotroll";
            this.btnUserCotroll.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.btnUserCotroll.Size = new System.Drawing.Size(250, 87);
            this.btnUserCotroll.TabIndex = 4;
            this.btnUserCotroll.Text = "User Controll";
            this.btnUserCotroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserCotroll.UseVisualStyleBackColor = false;
            this.btnUserCotroll.Click += new System.EventHandler(this.btnUserCotroll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.panelMenuDashboard);
            this.Controls.Add(this.labelDashBoard);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.panelMenuDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label labelDashBoard;
        private System.Windows.Forms.Panel panelMenuDashboard;
        private System.Windows.Forms.Button lblMinimize;
        private System.Windows.Forms.Button btnUserCotroll;
    }

}