namespace Drawdy_Chapter5_9
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
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(144, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dice Simulator";
            // 
            // picDice1
            // 
            this.picDice1.Image = global::Drawdy_Chapter5_9.Properties.Resources._1Die;
            this.picDice1.Location = new System.Drawing.Point(12, 76);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(233, 216);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 1;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Image = global::Drawdy_Chapter5_9.Properties.Resources._1Die;
            this.picDice2.Location = new System.Drawing.Point(260, 76);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(233, 216);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 2;
            this.picDice2.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(53, 329);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(121, 57);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(309, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 412);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnExit;
    }
}

