namespace MilkbarPOS.Forms
{
    partial class LoginForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.lblmilkbar = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(46, 184);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(46, 258);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(151, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(114, 410);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(208, 18);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Invalid username or password!";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidepanel.BackColor = System.Drawing.Color.MediumPurple;
            this.sidepanel.Controls.Add(this.lblmilkbar);
            this.sidepanel.Controls.Add(this.pictureBox);
            this.sidepanel.Location = new System.Drawing.Point(447, -2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(352, 508);
            this.sidepanel.TabIndex = 7;
            // 
            // lblmilkbar
            // 
            this.lblmilkbar.AutoSize = true;
            this.lblmilkbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmilkbar.ForeColor = System.Drawing.Color.White;
            this.lblmilkbar.Location = new System.Drawing.Point(76, 29);
            this.lblmilkbar.Name = "lblmilkbar";
            this.lblmilkbar.Size = new System.Drawing.Size(192, 58);
            this.lblmilkbar.TabIndex = 1;
            this.lblmilkbar.Text = "MilkBar";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(36, 164);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(285, 279);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(115, 95);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(207, 70);
            this.lbllogin.TabIndex = 8;
            this.lbllogin.Text = "LOGIN";
            // 
            // lblx
            // 
            this.lblx.BackColor = System.Drawing.Color.Red;
            this.lblx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx.Location = new System.Drawing.Point(-3, -2);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(38, 41);
            this.lblx.TabIndex = 9;
            this.lblx.Text = "X";
            this.lblx.UseVisualStyleBackColor = false;
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(325, 328);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(62, 20);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Show";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(50, 286);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(337, 36);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(50, 211);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(337, 36);
            this.txtUsername.TabIndex = 12;
            // 
            // lblMinimize
            // 
            this.lblMinimize.BackColor = System.Drawing.Color.DarkGray;
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinimize.Location = new System.Drawing.Point(32, -2);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(38, 41);
            this.lblMinimize.TabIndex = 13;
            this.lblMinimize.Text = "--";
            this.lblMinimize.UseVisualStyleBackColor = false;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(798, 503);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblmilkbar;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button lblMinimize;
    }
}