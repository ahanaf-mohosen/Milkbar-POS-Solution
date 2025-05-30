namespace MilkbarPOS.Forms
{
    partial class UserControllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControllForm));
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Button();
            this.lblUserRolePannel = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvUserRole = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRole)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.lblMinimize);
            this.toppanel.Controls.Add(this.lblx);
            this.toppanel.Controls.Add(this.lblUserRolePannel);
            this.toppanel.Location = new System.Drawing.Point(-1, -2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(901, 171);
            this.toppanel.TabIndex = 26;
            // 
            // lblMinimize
            // 
            this.lblMinimize.BackColor = System.Drawing.Color.DarkGray;
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinimize.Location = new System.Drawing.Point(34, -1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(38, 41);
            this.lblMinimize.TabIndex = 15;
            this.lblMinimize.Text = "--";
            this.lblMinimize.UseVisualStyleBackColor = false;
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
            // 
            // lblUserRolePannel
            // 
            this.lblUserRolePannel.AutoSize = true;
            this.lblUserRolePannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserRolePannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRolePannel.Location = new System.Drawing.Point(255, 68);
            this.lblUserRolePannel.Name = "lblUserRolePannel";
            this.lblUserRolePannel.Size = new System.Drawing.Size(386, 51);
            this.lblUserRolePannel.TabIndex = 0;
            this.lblUserRolePannel.Text = "USER CONTROLL";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(171, 276);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(67, 28);
            this.lblUserRole.TabIndex = 15;
            this.lblUserRole.Text = "Role :";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(171, 314);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 28);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "Username :";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(171, 352);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 28);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(278, 311);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 28);
            this.txtUsername.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(278, 349);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 28);
            this.txtPassword.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(174, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.btnAdd.Size = new System.Drawing.Size(123, 41);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(322, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.btnUpdate.Size = new System.Drawing.Size(123, 41);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(474, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(2, 0, 13, 0);
            this.btnDelete.Size = new System.Drawing.Size(123, 42);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvUserRole
            // 
            this.dgvUserRole.ColumnHeadersHeight = 29;
            this.dgvUserRole.Location = new System.Drawing.Point(174, 449);
            this.dgvUserRole.Name = "dgvUserRole";
            this.dgvUserRole.ReadOnly = true;
            this.dgvUserRole.RowHeadersWidth = 51;
            this.dgvUserRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserRole.Size = new System.Drawing.Size(564, 150);
            this.dgvUserRole.TabIndex = 24;
            this.dgvUserRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRole_CellContentClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(386, 626);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 18);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status Message";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(278, 275);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(239, 24);
            this.comboBox.TabIndex = 27;
            // 
            // UserControllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvUserRole);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserControllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControllForm";
            this.Load += new System.EventHandler(this.UserControllForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button lblMinimize;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.Label lblUserRolePannel;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvUserRole;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox;
    }
}