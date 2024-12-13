namespace Drawdy_Chapter4_9
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPenny = new System.Windows.Forms.Label();
            this.lblNickel = new System.Windows.Forms.Label();
            this.lblDime = new System.Windows.Forms.Label();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.txtNickel = new System.Windows.Forms.TextBox();
            this.txtDime = new System.Windows.Forms.TextBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change For a Dollar";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPenny
            // 
            this.lblPenny.AutoSize = true;
            this.lblPenny.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenny.Location = new System.Drawing.Point(12, 100);
            this.lblPenny.Name = "lblPenny";
            this.lblPenny.Size = new System.Drawing.Size(155, 32);
            this.lblPenny.TabIndex = 1;
            this.lblPenny.Text = "Please Enter Number \r\nof Pennies:";
            // 
            // lblNickel
            // 
            this.lblNickel.AutoSize = true;
            this.lblNickel.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickel.Location = new System.Drawing.Point(12, 161);
            this.lblNickel.Name = "lblNickel";
            this.lblNickel.Size = new System.Drawing.Size(150, 32);
            this.lblNickel.TabIndex = 2;
            this.lblNickel.Text = "Please Enter Number\r\nof Nickels:";
            // 
            // lblDime
            // 
            this.lblDime.AutoSize = true;
            this.lblDime.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDime.Location = new System.Drawing.Point(12, 229);
            this.lblDime.Name = "lblDime";
            this.lblDime.Size = new System.Drawing.Size(150, 32);
            this.lblDime.TabIndex = 3;
            this.lblDime.Text = "Please Enter Number\r\nof Dimes:";
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarter.Location = new System.Drawing.Point(12, 297);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(150, 32);
            this.lblQuarter.TabIndex = 4;
            this.lblQuarter.Text = "Please Enter Number\r\nof Quarters:";
            // 
            // txtPenny
            // 
            this.txtPenny.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenny.Location = new System.Drawing.Point(213, 100);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.Size = new System.Drawing.Size(100, 23);
            this.txtPenny.TabIndex = 5;
            // 
            // txtNickel
            // 
            this.txtNickel.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickel.Location = new System.Drawing.Point(213, 161);
            this.txtNickel.Name = "txtNickel";
            this.txtNickel.Size = new System.Drawing.Size(100, 23);
            this.txtNickel.TabIndex = 6;
            // 
            // txtDime
            // 
            this.txtDime.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDime.Location = new System.Drawing.Point(213, 229);
            this.txtDime.Name = "txtDime";
            this.txtDime.Size = new System.Drawing.Size(100, 23);
            this.txtDime.TabIndex = 7;
            // 
            // txtQuarter
            // 
            this.txtQuarter.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarter.Location = new System.Drawing.Point(213, 297);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(100, 23);
            this.txtQuarter.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(176, 340);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 38);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Exit";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(56, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Calculate";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(56, 390);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(231, 42);
            this.lblResult.TabIndex = 11;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 441);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.txtDime);
            this.Controls.Add(this.txtNickel);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.lblQuarter);
            this.Controls.Add(this.lblDime);
            this.Controls.Add(this.lblNickel);
            this.Controls.Add(this.lblPenny);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPenny;
        private System.Windows.Forms.Label lblNickel;
        private System.Windows.Forms.Label lblDime;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.TextBox txtPenny;
        private System.Windows.Forms.TextBox txtNickel;
        private System.Windows.Forms.TextBox txtDime;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

