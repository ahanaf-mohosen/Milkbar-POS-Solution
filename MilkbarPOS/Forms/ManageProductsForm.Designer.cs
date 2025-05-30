namespace MilkbarPOS.Forms
{
    partial class ManageProductsForm
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
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductsForm));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Button();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(170, 262);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(132, 28);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(170, 300);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 28);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price :";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(170, 338);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(90, 28);
            this.lblStockQuantity.TabIndex = 2;
            this.lblStockQuantity.Text = "Quantity :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(309, 299);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 28);
            this.txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(309, 337);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(240, 28);
            this.txtStock.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(173, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.btnAdd.Size = new System.Drawing.Size(123, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(321, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.btnUpdate.Size = new System.Drawing.Size(123, 41);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(473, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(2, 0, 13, 0);
            this.btnDelete.Size = new System.Drawing.Size(123, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeight = 29;
            this.dgvProducts.Location = new System.Drawing.Point(173, 437);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(564, 150);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(385, 614);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 18);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status Message";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.lblMinimize);
            this.toppanel.Controls.Add(this.lblx);
            this.toppanel.Controls.Add(this.lblManageProducts);
            this.toppanel.Location = new System.Drawing.Point(-1, -2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(901, 171);
            this.toppanel.TabIndex = 14;
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
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
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
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.Location = new System.Drawing.Point(206, 68);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(461, 51);
            this.lblManageProducts.TabIndex = 0;
            this.lblManageProducts.Text = "MANAGE PRODUCTS";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(309, 261);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 28);
            this.txtProductName.TabIndex = 3;
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.Label lblManageProducts;
        private System.Windows.Forms.Button lblMinimize;
        private System.Windows.Forms.TextBox txtProductName;
    }
}
