namespace MilkbarPOS.Forms
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbCashier = new System.Windows.Forms.ComboBox();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblx = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(171, 269);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(122, 22);
            this.dtStart.TabIndex = 0;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(420, 269);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(121, 22);
            this.dtEnd.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(93, 274);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 23);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(346, 274);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 23);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date :";
            // 
            // cmbCashier
            // 
            this.cmbCashier.FormattingEnabled = true;
            this.cmbCashier.Location = new System.Drawing.Point(171, 315);
            this.cmbCashier.Name = "cmbCashier";
            this.cmbCashier.Size = new System.Drawing.Size(121, 24);
            this.cmbCashier.TabIndex = 4;
            this.cmbCashier.SelectedIndexChanged += new System.EventHandler(this.cmbCashier_SelectedIndexChanged);
            // 
            // lblCashier
            // 
            this.lblCashier.Location = new System.Drawing.Point(93, 318);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(65, 23);
            this.lblCashier.TabIndex = 5;
            this.lblCashier.Text = "Cashier :";
            // 
            // lblProduct
            // 
            this.lblProduct.Location = new System.Drawing.Point(346, 318);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 23);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(664, 310);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(132, 33);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(420, 314);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 6;
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(96, 345);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(700, 250);
            this.dgvReport.TabIndex = 9;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Location = new System.Drawing.Point(92, 619);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(280, 20);
            this.lblSummary.TabIndex = 10;
            this.lblSummary.Text = "Total Sales: $0.00 | Transactions: $0.00";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.lblMinimize);
            this.toppanel.Controls.Add(this.lblx);
            this.toppanel.Controls.Add(this.lblReport);
            this.toppanel.Location = new System.Drawing.Point(-1, -3);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(901, 171);
            this.toppanel.TabIndex = 12;
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
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(343, 68);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(230, 51);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "REPORTS";
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.cmbCashier);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button lblx;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button lblMinimize;
    }
}
