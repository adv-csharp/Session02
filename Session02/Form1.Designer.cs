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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJalaliMonthName);
            this.Controls.Add(this.btnMiladi2Jalali);
            this.Controls.Add(this.btnJalali2Miladi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnJalali2Miladi;
        private Button btnMiladi2Jalali;
        private Button btnJalaliMonthName;
    }
}