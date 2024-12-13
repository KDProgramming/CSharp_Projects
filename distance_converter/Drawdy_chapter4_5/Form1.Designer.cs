namespace Drawdy_chapter4_5
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
            this.lblEntry = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxFrom = new System.Windows.Forms.GroupBox();
            this.grpBoxTo = new System.Windows.Forms.GroupBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.grpBoxFrom.SuspendLayout();
            this.grpBoxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(35, 32);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(195, 16);
            this.lblEntry.TabIndex = 0;
            this.lblEntry.Text = "Enter a distance to convert:";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(263, 32);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(171, 20);
            this.txtEntry.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(35, 271);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(147, 16);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Converted Distance:";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(263, 271);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(171, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(57, 326);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 31);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxFrom
            // 
            this.grpBoxFrom.Controls.Add(this.lstFrom);
            this.grpBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFrom.Location = new System.Drawing.Point(38, 90);
            this.grpBoxFrom.Name = "grpBoxFrom";
            this.grpBoxFrom.Size = new System.Drawing.Size(156, 150);
            this.grpBoxFrom.TabIndex = 6;
            this.grpBoxFrom.TabStop = false;
            this.grpBoxFrom.Text = "From";
            // 
            // grpBoxTo
            // 
            this.grpBoxTo.Controls.Add(this.lstTo);
            this.grpBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTo.Location = new System.Drawing.Point(263, 90);
            this.grpBoxTo.Name = "grpBoxTo";
            this.grpBoxTo.Size = new System.Drawing.Size(171, 150);
            this.grpBoxTo.TabIndex = 7;
            this.grpBoxTo.TabStop = false;
            this.grpBoxTo.Text = "To";
            // 
            // lstFrom
            // 
            this.lstFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 20;
            this.lstFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstFrom.Location = new System.Drawing.Point(19, 31);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(120, 84);
            this.lstFrom.TabIndex = 0;
            // 
            // lstTo
            // 
            this.lstTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 20;
            this.lstTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstTo.Location = new System.Drawing.Point(28, 31);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(120, 84);
            this.lstTo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 373);
            this.Controls.Add(this.grpBoxTo);
            this.Controls.Add(this.grpBoxFrom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxFrom.ResumeLayout(false);
            this.grpBoxTo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxFrom;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.GroupBox grpBoxTo;
        private System.Windows.Forms.ListBox lstTo;
    }
}

