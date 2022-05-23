namespace Session02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJalali2Miladi = new System.Windows.Forms.Button();
            this.btnMiladi2Jalali = new System.Windows.Forms.Button();
            this.btnJalaliMonthName = new System.Windows.Forms.Button();
            this.btnOutSample = new System.Windows.Forms.Button();
            this.btnRefSample = new System.Windows.Forms.Button();
            this.btnTouple = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJalali2Miladi
            // 
            this.btnJalali2Miladi.Location = new System.Drawing.Point(12, 81);
            this.btnJalali2Miladi.Name = "btnJalali2Miladi";
            this.btnJalali2Miladi.Size = new System.Drawing.Size(150, 51);
            this.btnJalali2Miladi.TabIndex = 0;
            this.btnJalali2Miladi.Text = "Jalali to Miladi";
            this.btnJalali2Miladi.UseVisualStyleBackColor = true;
            this.btnJalali2Miladi.Click += new System.EventHandler(this.btnJalali2Miladi_Click);
            // 
            // btnMiladi2Jalali
            // 
            this.btnMiladi2Jalali.Location = new System.Drawing.Point(12, 12);
            this.btnMiladi2Jalali.Name = "btnMiladi2Jalali";
            this.btnMiladi2Jalali.Size = new System.Drawing.Size(150, 51);
            this.btnMiladi2Jalali.TabIndex = 1;
            this.btnMiladi2Jalali.Text = "Miladi to Jalali";
            this.btnMiladi2Jalali.UseVisualStyleBackColor = true;
            this.btnMiladi2Jalali.Click += new System.EventHandler(this.btnMiladi2Jalali_Click);
            // 
            // btnJalaliMonthName
            // 
            this.btnJalaliMonthName.Location = new System.Drawing.Point(168, 12);
            this.btnJalaliMonthName.Name = "btnJalaliMonthName";
            this.btnJalaliMonthName.Size = new System.Drawing.Size(150, 51);
            this.btnJalaliMonthName.TabIndex = 2;
            this.btnJalaliMonthName.Text = "Jalali Month Name";
            this.btnJalaliMonthName.UseVisualStyleBackColor = true;
            this.btnJalaliMonthName.Click += new System.EventHandler(this.btnJalaliMonthName_Click);
            // 
            // btnOutSample
            // 
            this.btnOutSample.Location = new System.Drawing.Point(638, 12);
            this.btnOutSample.Name = "btnOutSample";
            this.btnOutSample.Size = new System.Drawing.Size(150, 51);
            this.btnOutSample.TabIndex = 3;
            this.btnOutSample.Text = "Out Sample";
            this.btnOutSample.UseVisualStyleBackColor = true;
            this.btnOutSample.Click += new System.EventHandler(this.btnOutSample_Click);
            // 
            // btnRefSample
            // 
            this.btnRefSample.Location = new System.Drawing.Point(638, 81);
            this.btnRefSample.Name = "btnRefSample";
            this.btnRefSample.Size = new System.Drawing.Size(150, 51);
            this.btnRefSample.TabIndex = 4;
            this.btnRefSample.Text = "Ref Sample";
            this.btnRefSample.UseVisualStyleBackColor = true;
            this.btnRefSample.Click += new System.EventHandler(this.btnRefSample_Click);
            // 
            // btnTouple
            // 
            this.btnTouple.Location = new System.Drawing.Point(638, 148);
            this.btnTouple.Name = "btnTouple";
            this.btnTouple.Size = new System.Drawing.Size(150, 49);
            this.btnTouple.TabIndex = 5;
            this.btnTouple.Text = "Touple";
            this.btnTouple.UseVisualStyleBackColor = true;
            this.btnTouple.Click += new System.EventHandler(this.btnTouple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "♦";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTouple);
            this.Controls.Add(this.btnRefSample);
            this.Controls.Add(this.btnOutSample);
            this.Controls.Add(this.btnJalaliMonthName);
            this.Controls.Add(this.btnMiladi2Jalali);
            this.Controls.Add(this.btnJalali2Miladi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnJalali2Miladi;
        private Button btnMiladi2Jalali;
        private Button btnJalaliMonthName;
        private Button btnOutSample;
        private Button btnRefSample;
        private Button btnTouple;
        private Label label1;
    }
}