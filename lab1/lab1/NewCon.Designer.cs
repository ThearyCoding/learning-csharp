namespace lab1
{
    partial class NewCon
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
            this.btnadd = new System.Windows.Forms.Button();
            this.combcountry = new System.Windows.Forms.ComboBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(316, 78);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(135, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // combcountry
            // 
            this.combcountry.FormattingEnabled = true;
            this.combcountry.Items.AddRange(new object[] {
            "China",
            "India",
            "Japan",
            "South Korea",
            "North Korea",
            "Indonesia",
            "Pakistan",
            "Bangladesh",
            "Vietnam",
            "Thailand",
            "Malaysia",
            "Cambodia"});
            this.combcountry.Location = new System.Drawing.Point(45, 136);
            this.combcountry.Name = "combcountry";
            this.combcountry.Size = new System.Drawing.Size(242, 21);
            this.combcountry.TabIndex = 1;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(45, 78);
            this.txtcon.Multiline = true;
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(242, 28);
            this.txtcon.TabIndex = 2;
            // 
            // NewCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.combcountry);
            this.Controls.Add(this.btnadd);
            this.Name = "NewCon";
            this.Text = "NewCon";
            this.Load += new System.EventHandler(this.NewCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox combcountry;
        private System.Windows.Forms.TextBox txtcon;
    }
}