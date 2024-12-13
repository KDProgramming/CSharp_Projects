namespace Drawdy_chapter_10
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
            this.lblResults = new System.Windows.Forms.Label();
            this.picBoxRock = new System.Windows.Forms.PictureBox();
            this.picBoxPaper = new System.Windows.Forms.PictureBox();
            this.picBoxScissors = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rock Paper Scissors Game";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(33, 297);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 24);
            this.lblResults.TabIndex = 1;
            // 
            // picBoxRock
            // 
            this.picBoxRock.Image = global::Drawdy_chapter_10.Properties.Resources.Rock;
            this.picBoxRock.Location = new System.Drawing.Point(12, 97);
            this.picBoxRock.Name = "picBoxRock";
            this.picBoxRock.Size = new System.Drawing.Size(158, 167);
            this.picBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRock.TabIndex = 2;
            this.picBoxRock.TabStop = false;
            this.picBoxRock.Click += new System.EventHandler(this.picBoxRock_Click);
            // 
            // picBoxPaper
            // 
            this.picBoxPaper.Image = global::Drawdy_chapter_10.Properties.Resources.Paper;
            this.picBoxPaper.Location = new System.Drawing.Point(176, 97);
            this.picBoxPaper.Name = "picBoxPaper";
            this.picBoxPaper.Size = new System.Drawing.Size(158, 167);
            this.picBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPaper.TabIndex = 3;
            this.picBoxPaper.TabStop = false;
            this.picBoxPaper.Click += new System.EventHandler(this.picBoxPaper_Click);
            // 
            // picBoxScissors
            // 
            this.picBoxScissors.Image = global::Drawdy_chapter_10.Properties.Resources.Scissors;
            this.picBoxScissors.Location = new System.Drawing.Point(340, 97);
            this.picBoxScissors.Name = "picBoxScissors";
            this.picBoxScissors.Size = new System.Drawing.Size(158, 167);
            this.picBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxScissors.TabIndex = 4;
            this.picBoxScissors.TabStop = false;
            this.picBoxScissors.Click += new System.EventHandler(this.picBoxScissors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 441);
            this.Controls.Add(this.picBoxScissors);
            this.Controls.Add(this.picBoxPaper);
            this.Controls.Add(this.picBoxRock);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox picBoxRock;
        private System.Windows.Forms.PictureBox picBoxPaper;
        private System.Windows.Forms.PictureBox picBoxScissors;
    }
}

