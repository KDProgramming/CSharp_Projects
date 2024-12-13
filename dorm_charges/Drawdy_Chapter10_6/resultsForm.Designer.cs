namespace Drawdy_Chapter10_6
{
    partial class resultsForm
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
            this.lblDormChargeTitle = new System.Windows.Forms.Label();
            this.lblDormTotal = new System.Windows.Forms.Label();
            this.lblMealTotalTitle = new System.Windows.Forms.Label();
            this.lblMealTotal = new System.Windows.Forms.Label();
            this.lblTotalChargesTitle = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDormChargeTitle
            // 
            this.lblDormChargeTitle.AutoSize = true;
            this.lblDormChargeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormChargeTitle.Location = new System.Drawing.Point(38, 26);
            this.lblDormChargeTitle.Name = "lblDormChargeTitle";
            this.lblDormChargeTitle.Size = new System.Drawing.Size(208, 20);
            this.lblDormChargeTitle.TabIndex = 0;
            this.lblDormChargeTitle.Text = "Total Dormitory Charges:";
            // 
            // lblDormTotal
            // 
            this.lblDormTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDormTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormTotal.Location = new System.Drawing.Point(39, 60);
            this.lblDormTotal.Name = "lblDormTotal";
            this.lblDormTotal.Size = new System.Drawing.Size(303, 81);
            this.lblDormTotal.TabIndex = 1;
            // 
            // lblMealTotalTitle
            // 
            this.lblMealTotalTitle.AutoSize = true;
            this.lblMealTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealTotalTitle.Location = new System.Drawing.Point(38, 172);
            this.lblMealTotalTitle.Name = "lblMealTotalTitle";
            this.lblMealTotalTitle.Size = new System.Drawing.Size(209, 20);
            this.lblMealTotalTitle.TabIndex = 2;
            this.lblMealTotalTitle.Text = "Total Meal Plan Charges:";
            // 
            // lblMealTotal
            // 
            this.lblMealTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMealTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealTotal.Location = new System.Drawing.Point(39, 215);
            this.lblMealTotal.Name = "lblMealTotal";
            this.lblMealTotal.Size = new System.Drawing.Size(303, 85);
            this.lblMealTotal.TabIndex = 3;
            // 
            // lblTotalChargesTitle
            // 
            this.lblTotalChargesTitle.AutoSize = true;
            this.lblTotalChargesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChargesTitle.Location = new System.Drawing.Point(38, 322);
            this.lblTotalChargesTitle.Name = "lblTotalChargesTitle";
            this.lblTotalChargesTitle.Size = new System.Drawing.Size(109, 20);
            this.lblTotalChargesTitle.TabIndex = 4;
            this.lblTotalChargesTitle.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(39, 368);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(303, 78);
            this.lblGrandTotal.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(95, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // resultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTotalChargesTitle);
            this.Controls.Add(this.lblMealTotal);
            this.Controls.Add(this.lblMealTotalTitle);
            this.Controls.Add(this.lblDormTotal);
            this.Controls.Add(this.lblDormChargeTitle);
            this.Name = "resultsForm";
            this.Text = "resultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDormChargeTitle;
        private System.Windows.Forms.Label lblMealTotalTitle;
        private System.Windows.Forms.Label lblTotalChargesTitle;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblDormTotal;
        public System.Windows.Forms.Label lblMealTotal;
        public System.Windows.Forms.Label lblGrandTotal;
    }
}