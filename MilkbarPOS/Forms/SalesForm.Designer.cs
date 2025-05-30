// SalesForm.Designer.cs

namespace MilkbarPOS.Forms
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCheckout;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Button();
            this.lblSalesModule = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownHeight = 102;
            this.cmbProducts.IntegralHeight = false;
            this.cmbProducts.ItemHeight = 16;
            this.cmbProducts.Location = new System.Drawing.Point(165, 287);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(246, 24);
            this.cmbProducts.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(435, 287);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(68, 24);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Location = new System.Drawing.Point(162, 316);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(600, 200);
            this.dgvCart.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(373, 524);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(60, 24);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(324, 618);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Product added to cart";
            this.lblStatus.Visible = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(162, 526);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(141, 20);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal : $0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(492, 526);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(242, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total After Discount : $0.00";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(606, 581);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAddToCart.Size = new System.Drawing.Size(156, 45);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(606, 632);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnCheckout.Size = new System.Drawing.Size(156, 45);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.lblMinimize);
            this.toppanel.Controls.Add(this.lblx);
            this.toppanel.Controls.Add(this.lblSalesModule);
            this.toppanel.Location = new System.Drawing.Point(-1, -3);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(901, 171);
            this.toppanel.TabIndex = 13;
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
            // lblSalesModule
            // 
            this.lblSalesModule.AutoSize = true;
            this.lblSalesModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalesModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesModule.Location = new System.Drawing.Point(272, 68);
            this.lblSalesModule.Name = "lblSalesModule";
            this.lblSalesModule.Size = new System.Drawing.Size(357, 51);
            this.lblSalesModule.TabIndex = 0;
            this.lblSalesModule.Text = "SALES MODULE";
            this.lblSalesModule.Click += new System.EventHandler(this.lblSalesModule_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.Location = new System.Drawing.Point(433, 528);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(22, 18);
            this.labelPercentage.TabIndex = 14;
            this.labelPercentage.Text = "%";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Form";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.Label lblSalesModule;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Button lblMinimize;
    }
}
