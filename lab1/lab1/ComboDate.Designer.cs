namespace lab1
{
    partial class ComboDate
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
            this.monthcombo = new System.Windows.Forms.ComboBox();
            this.yearcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combomonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.daycombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthcombo
            // 
            this.monthcombo.FormattingEnabled = true;
            this.monthcombo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthcombo.Location = new System.Drawing.Point(192, 137);
            this.monthcombo.Name = "monthcombo";
            this.monthcombo.Size = new System.Drawing.Size(121, 21);
            this.monthcombo.TabIndex = 0;
            this.monthcombo.SelectedIndexChanged += new System.EventHandler(this.monthcombo_SelectedIndexChanged_1);
            // 
            // yearcombo
            // 
            this.yearcombo.FormattingEnabled = true;
            this.yearcombo.Location = new System.Drawing.Point(358, 137);
            this.yearcombo.Name = "yearcombo";
            this.yearcombo.Size = new System.Drawing.Size(121, 21);
            this.yearcombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // combomonth
            // 
            this.combomonth.AutoSize = true;
            this.combomonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomonth.Location = new System.Drawing.Point(227, 95);
            this.combomonth.Name = "combomonth";
            this.combomonth.Size = new System.Drawing.Size(50, 18);
            this.combomonth.TabIndex = 1;
            this.combomonth.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year";
            // 
            // daycombo
            // 
            this.daycombo.FormattingEnabled = true;
            this.daycombo.Location = new System.Drawing.Point(12, 137);
            this.daycombo.Name = "daycombo";
            this.daycombo.Size = new System.Drawing.Size(121, 21);
            this.daycombo.TabIndex = 2;
            // 
            // ComboDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 277);
            this.Controls.Add(this.daycombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combomonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearcombo);
            this.Controls.Add(this.monthcombo);
            this.Name = "ComboDate";
            this.Text = "ComboDate";
            this.Load += new System.EventHandler(this.ComboDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox monthcombo;
        private System.Windows.Forms.ComboBox yearcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label combomonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox daycombo;
    }
}