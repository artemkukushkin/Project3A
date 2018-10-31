namespace kukushkinProject3A
{
    partial class frmDebtRatio
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLiability = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.txtLiability = new System.Windows.Forms.TextBox();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(85, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(223, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLiability
            // 
            this.lblLiability.AutoSize = true;
            this.lblLiability.Location = new System.Drawing.Point(82, 75);
            this.lblLiability.Name = "lblLiability";
            this.lblLiability.Size = new System.Drawing.Size(79, 13);
            this.lblLiability.TabIndex = 2;
            this.lblLiability.Text = "Total Liabilities:";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Location = new System.Drawing.Point(82, 147);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(68, 13);
            this.lblAssets.TabIndex = 3;
            this.lblAssets.Text = "Total Assets:";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Location = new System.Drawing.Point(82, 242);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(61, 13);
            this.lblDebt.TabIndex = 4;
            this.lblDebt.Text = "Debt Ratio:";
            // 
            // txtLiability
            // 
            this.txtLiability.Location = new System.Drawing.Point(198, 72);
            this.txtLiability.Name = "txtLiability";
            this.txtLiability.Size = new System.Drawing.Size(100, 20);
            this.txtLiability.TabIndex = 5;
            // 
            // txtAssets
            // 
            this.txtAssets.Location = new System.Drawing.Point(198, 144);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.Size = new System.Drawing.Size(100, 20);
            this.txtAssets.TabIndex = 6;
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(198, 239);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(100, 20);
            this.txtDebt.TabIndex = 7;
            // 
            // frmDebtRatio
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(371, 405);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.txtLiability);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblAssets);
            this.Controls.Add(this.lblLiability);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmDebtRatio";
            this.Text = "Debt Ratio Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLiability;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.TextBox txtLiability;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.TextBox txtDebt;
    }
}

