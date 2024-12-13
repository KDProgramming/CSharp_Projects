namespace Drawdy_Chapter10_6
{
    partial class mainForm
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
            this.lblDormTitle = new System.Windows.Forms.Label();
            this.lblMealTitle = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMeals = new System.Windows.Forms.GroupBox();
            this.radioUnlimited = new System.Windows.Forms.RadioButton();
            this.radio14Meals = new System.Windows.Forms.RadioButton();
            this.radio7Meals = new System.Windows.Forms.RadioButton();
            this.grpDorm = new System.Windows.Forms.GroupBox();
            this.radioSuites = new System.Windows.Forms.RadioButton();
            this.radioFarthing = new System.Windows.Forms.RadioButton();
            this.radioPike = new System.Windows.Forms.RadioButton();
            this.radioAllen = new System.Windows.Forms.RadioButton();
            this.grpMeals.SuspendLayout();
            this.grpDorm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDormTitle
            // 
            this.lblDormTitle.AutoSize = true;
            this.lblDormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormTitle.Location = new System.Drawing.Point(23, 21);
            this.lblDormTitle.Name = "lblDormTitle";
            this.lblDormTitle.Size = new System.Drawing.Size(210, 20);
            this.lblDormTitle.TabIndex = 0;
            this.lblDormTitle.Text = "Choose Yoour Dormitory:";
            // 
            // lblMealTitle
            // 
            this.lblMealTitle.AutoSize = true;
            this.lblMealTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealTitle.Location = new System.Drawing.Point(23, 143);
            this.lblMealTitle.Name = "lblMealTitle";
            this.lblMealTitle.Size = new System.Drawing.Size(201, 20);
            this.lblMealTitle.TabIndex = 1;
            this.lblMealTitle.Text = "Choose Your Meal Plan:";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(47, 290);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 47);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(198, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 47);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMeals
            // 
            this.grpMeals.Controls.Add(this.radioUnlimited);
            this.grpMeals.Controls.Add(this.radio14Meals);
            this.grpMeals.Controls.Add(this.radio7Meals);
            this.grpMeals.Location = new System.Drawing.Point(27, 166);
            this.grpMeals.Name = "grpMeals";
            this.grpMeals.Size = new System.Drawing.Size(289, 118);
            this.grpMeals.TabIndex = 11;
            this.grpMeals.TabStop = false;
            // 
            // radioUnlimited
            // 
            this.radioUnlimited.AutoSize = true;
            this.radioUnlimited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUnlimited.Location = new System.Drawing.Point(15, 77);
            this.radioUnlimited.Name = "radioUnlimited";
            this.radioUnlimited.Size = new System.Drawing.Size(139, 24);
            this.radioUnlimited.TabIndex = 11;
            this.radioUnlimited.TabStop = true;
            this.radioUnlimited.Text = "Unlimited Meals";
            this.radioUnlimited.UseVisualStyleBackColor = true;
            // 
            // radio14Meals
            // 
            this.radio14Meals.AutoSize = true;
            this.radio14Meals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio14Meals.Location = new System.Drawing.Point(15, 47);
            this.radio14Meals.Name = "radio14Meals";
            this.radio14Meals.Size = new System.Drawing.Size(164, 24);
            this.radio14Meals.TabIndex = 10;
            this.radio14Meals.TabStop = true;
            this.radio14Meals.Text = "14 Meals Per Week";
            this.radio14Meals.UseVisualStyleBackColor = true;
            // 
            // radio7Meals
            // 
            this.radio7Meals.AutoSize = true;
            this.radio7Meals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio7Meals.Location = new System.Drawing.Point(15, 17);
            this.radio7Meals.Name = "radio7Meals";
            this.radio7Meals.Size = new System.Drawing.Size(155, 24);
            this.radio7Meals.TabIndex = 9;
            this.radio7Meals.TabStop = true;
            this.radio7Meals.Text = "7 Meals Per Week";
            this.radio7Meals.UseVisualStyleBackColor = true;
            // 
            // grpDorm
            // 
            this.grpDorm.Controls.Add(this.radioSuites);
            this.grpDorm.Controls.Add(this.radioFarthing);
            this.grpDorm.Controls.Add(this.radioPike);
            this.grpDorm.Controls.Add(this.radioAllen);
            this.grpDorm.Location = new System.Drawing.Point(27, 50);
            this.grpDorm.Name = "grpDorm";
            this.grpDorm.Size = new System.Drawing.Size(289, 90);
            this.grpDorm.TabIndex = 12;
            this.grpDorm.TabStop = false;
            // 
            // radioSuites
            // 
            this.radioSuites.AutoSize = true;
            this.radioSuites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuites.Location = new System.Drawing.Point(131, 49);
            this.radioSuites.Name = "radioSuites";
            this.radioSuites.Size = new System.Drawing.Size(144, 24);
            this.radioSuites.TabIndex = 9;
            this.radioSuites.TabStop = true;
            this.radioSuites.Text = "University Suites";
            this.radioSuites.UseVisualStyleBackColor = true;
            // 
            // radioFarthing
            // 
            this.radioFarthing.AutoSize = true;
            this.radioFarthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFarthing.Location = new System.Drawing.Point(131, 19);
            this.radioFarthing.Name = "radioFarthing";
            this.radioFarthing.Size = new System.Drawing.Size(117, 24);
            this.radioFarthing.TabIndex = 8;
            this.radioFarthing.TabStop = true;
            this.radioFarthing.Text = "Farthing Hall";
            this.radioFarthing.UseVisualStyleBackColor = true;
            // 
            // radioPike
            // 
            this.radioPike.AutoSize = true;
            this.radioPike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPike.Location = new System.Drawing.Point(20, 49);
            this.radioPike.Name = "radioPike";
            this.radioPike.Size = new System.Drawing.Size(88, 24);
            this.radioPike.TabIndex = 7;
            this.radioPike.TabStop = true;
            this.radioPike.Text = "Pike Hall";
            this.radioPike.UseVisualStyleBackColor = true;
            // 
            // radioAllen
            // 
            this.radioAllen.AutoSize = true;
            this.radioAllen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAllen.Location = new System.Drawing.Point(15, 19);
            this.radioAllen.Name = "radioAllen";
            this.radioAllen.Size = new System.Drawing.Size(93, 24);
            this.radioAllen.TabIndex = 6;
            this.radioAllen.TabStop = true;
            this.radioAllen.Text = "Allen Hall";
            this.radioAllen.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 364);
            this.Controls.Add(this.grpDorm);
            this.Controls.Add(this.grpMeals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMealTitle);
            this.Controls.Add(this.lblDormTitle);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.grpMeals.ResumeLayout(false);
            this.grpMeals.PerformLayout();
            this.grpDorm.ResumeLayout(false);
            this.grpDorm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDormTitle;
        private System.Windows.Forms.Label lblMealTitle;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpMeals;
        private System.Windows.Forms.RadioButton radioUnlimited;
        private System.Windows.Forms.RadioButton radio14Meals;
        private System.Windows.Forms.RadioButton radio7Meals;
        private System.Windows.Forms.GroupBox grpDorm;
        private System.Windows.Forms.RadioButton radioSuites;
        private System.Windows.Forms.RadioButton radioFarthing;
        private System.Windows.Forms.RadioButton radioPike;
        private System.Windows.Forms.RadioButton radioAllen;
    }
}

