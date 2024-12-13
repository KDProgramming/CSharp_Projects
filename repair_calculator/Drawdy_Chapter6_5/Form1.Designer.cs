namespace Drawdy_Chapter6_5
{
    partial class Form1
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
            this.grpOilLube = new System.Windows.Forms.GroupBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.grpFlushes = new System.Windows.Forms.GroupBox();
            this.grpPartsLabor = new System.Windows.Forms.GroupBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.chkTransFlush = new System.Windows.Forms.CheckBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.lblServiceLabor = new System.Windows.Forms.Label();
            this.lblPartsSummary = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.LblServiceLaborResult = new System.Windows.Forms.Label();
            this.lblPartsResult = new System.Windows.Forms.Label();
            this.lblTaxResult = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.grpOilLube.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.grpFlushes.SuspendLayout();
            this.grpPartsLabor.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilLube
            // 
            this.grpOilLube.Controls.Add(this.chkLubeJob);
            this.grpOilLube.Controls.Add(this.chkOilChange);
            this.grpOilLube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOilLube.Location = new System.Drawing.Point(12, 12);
            this.grpOilLube.Name = "grpOilLube";
            this.grpOilLube.Size = new System.Drawing.Size(162, 125);
            this.grpOilLube.TabIndex = 0;
            this.grpOilLube.TabStop = false;
            this.grpOilLube.Text = "Oil and Lube";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.chkTireRotation);
            this.grpMisc.Controls.Add(this.chkReplaceMuffler);
            this.grpMisc.Controls.Add(this.chkInspection);
            this.grpMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMisc.Location = new System.Drawing.Point(12, 153);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(162, 125);
            this.grpMisc.TabIndex = 1;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc";
            // 
            // grpFlushes
            // 
            this.grpFlushes.Controls.Add(this.chkTransFlush);
            this.grpFlushes.Controls.Add(this.chkRadiatorFlush);
            this.grpFlushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlushes.Location = new System.Drawing.Point(211, 12);
            this.grpFlushes.Name = "grpFlushes";
            this.grpFlushes.Size = new System.Drawing.Size(162, 125);
            this.grpFlushes.TabIndex = 1;
            this.grpFlushes.TabStop = false;
            this.grpFlushes.Text = "Flushes";
            // 
            // grpPartsLabor
            // 
            this.grpPartsLabor.Controls.Add(this.txtLabor);
            this.grpPartsLabor.Controls.Add(this.txtParts);
            this.grpPartsLabor.Controls.Add(this.lblLabor);
            this.grpPartsLabor.Controls.Add(this.lblParts);
            this.grpPartsLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPartsLabor.Location = new System.Drawing.Point(211, 153);
            this.grpPartsLabor.Name = "grpPartsLabor";
            this.grpPartsLabor.Size = new System.Drawing.Size(162, 125);
            this.grpPartsLabor.TabIndex = 1;
            this.grpPartsLabor.TabStop = false;
            this.grpPartsLabor.Text = "Parts and Labor";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblTotalResult);
            this.grpSummary.Controls.Add(this.lblTaxResult);
            this.grpSummary.Controls.Add(this.lblPartsResult);
            this.grpSummary.Controls.Add(this.LblServiceLaborResult);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.lblPartsSummary);
            this.grpSummary.Controls.Add(this.lblServiceLabor);
            this.grpSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(12, 284);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(361, 131);
            this.grpSummary.TabIndex = 2;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(12, 429);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 29);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(269, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(139, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(7, 34);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(120, 17);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "Oil Change ($26.00)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(7, 75);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(112, 17);
            this.chkLubeJob.TabIndex = 1;
            this.chkLubeJob.Text = "Lube Job ($18.00)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(6, 28);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(117, 17);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkReplaceMuffler
            // 
            this.chkReplaceMuffler.AutoSize = true;
            this.chkReplaceMuffler.Location = new System.Drawing.Point(7, 61);
            this.chkReplaceMuffler.Name = "chkReplaceMuffler";
            this.chkReplaceMuffler.Size = new System.Drawing.Size(149, 17);
            this.chkReplaceMuffler.TabIndex = 1;
            this.chkReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.chkReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(7, 93);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(129, 17);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "Tire Rotation ($20.00)";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(7, 34);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(136, 17);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // chkTransFlush
            // 
            this.chkTransFlush.AutoSize = true;
            this.chkTransFlush.Location = new System.Drawing.Point(6, 75);
            this.chkTransFlush.Name = "chkTransFlush";
            this.chkTransFlush.Size = new System.Drawing.Size(157, 17);
            this.chkTransFlush.TabIndex = 1;
            this.chkTransFlush.Text = "Transmission Flush ($80.00)";
            this.chkTransFlush.UseVisualStyleBackColor = true;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(6, 43);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(31, 13);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parts";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(6, 89);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(49, 13);
            this.lblLabor.TabIndex = 1;
            this.lblLabor.Text = "Labor ($)";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(61, 40);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(95, 20);
            this.txtParts.TabIndex = 2;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(61, 86);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(95, 20);
            this.txtLabor.TabIndex = 3;
            // 
            // lblServiceLabor
            // 
            this.lblServiceLabor.AutoSize = true;
            this.lblServiceLabor.Location = new System.Drawing.Point(6, 22);
            this.lblServiceLabor.Name = "lblServiceLabor";
            this.lblServiceLabor.Size = new System.Drawing.Size(94, 13);
            this.lblServiceLabor.TabIndex = 4;
            this.lblServiceLabor.Text = "Service and Labor";
            // 
            // lblPartsSummary
            // 
            this.lblPartsSummary.AutoSize = true;
            this.lblPartsSummary.Location = new System.Drawing.Point(6, 48);
            this.lblPartsSummary.Name = "lblPartsSummary";
            this.lblPartsSummary.Size = new System.Drawing.Size(31, 13);
            this.lblPartsSummary.TabIndex = 5;
            this.lblPartsSummary.Text = "Parts";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(6, 74);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TotalFees";
            // 
            // LblServiceLaborResult
            // 
            this.LblServiceLaborResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblServiceLaborResult.Location = new System.Drawing.Point(154, 16);
            this.LblServiceLaborResult.Name = "LblServiceLaborResult";
            this.LblServiceLaborResult.Size = new System.Drawing.Size(147, 19);
            this.LblServiceLaborResult.TabIndex = 8;
            // 
            // lblPartsResult
            // 
            this.lblPartsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsResult.Location = new System.Drawing.Point(154, 42);
            this.lblPartsResult.Name = "lblPartsResult";
            this.lblPartsResult.Size = new System.Drawing.Size(147, 19);
            this.lblPartsResult.TabIndex = 9;
            // 
            // lblTaxResult
            // 
            this.lblTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxResult.Location = new System.Drawing.Point(154, 68);
            this.lblTaxResult.Name = "lblTaxResult";
            this.lblTaxResult.Size = new System.Drawing.Size(147, 19);
            this.lblTaxResult.TabIndex = 10;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalResult.Location = new System.Drawing.Point(154, 94);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(147, 19);
            this.lblTotalResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 470);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPartsLabor);
            this.Controls.Add(this.grpFlushes);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpOilLube);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpOilLube.ResumeLayout(false);
            this.grpOilLube.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.grpFlushes.ResumeLayout(false);
            this.grpFlushes.PerformLayout();
            this.grpPartsLabor.ResumeLayout(false);
            this.grpPartsLabor.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOilLube;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.GroupBox grpFlushes;
        private System.Windows.Forms.GroupBox grpPartsLabor;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkTransFlush;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.Label lblServiceLabor;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblTaxResult;
        private System.Windows.Forms.Label lblPartsResult;
        private System.Windows.Forms.Label LblServiceLaborResult;
    }
}

