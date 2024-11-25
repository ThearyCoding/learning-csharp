namespace lab1
{
    partial class TaxSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtspouse = new System.Windows.Forms.TextBox();
            this.txtchil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtax = new System.Windows.Forms.Label();
            this.lblastsalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Salary = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Spouse = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Bonus = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Number of child = ";
            // 
            // txtbonus
            // 
            this.txtbonus.Location = new System.Drawing.Point(371, 116);
            this.txtbonus.Multiline = true;
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(183, 29);
            this.txtbonus.TabIndex = 1;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(371, 66);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(183, 29);
            this.txtsalary.TabIndex = 1;
            // 
            // txtspouse
            // 
            this.txtspouse.Location = new System.Drawing.Point(371, 167);
            this.txtspouse.Multiline = true;
            this.txtspouse.Name = "txtspouse";
            this.txtspouse.Size = new System.Drawing.Size(183, 29);
            this.txtspouse.TabIndex = 1;
            // 
            // txtchil
            // 
            this.txtchil.Location = new System.Drawing.Point(371, 227);
            this.txtchil.Multiline = true;
            this.txtchil.Name = "txtchil";
            this.txtchil.Size = new System.Drawing.Size(183, 29);
            this.txtchil.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tax = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Last Salary = ";
            // 
            // lbtax
            // 
            this.lbtax.AutoSize = true;
            this.lbtax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtax.ForeColor = System.Drawing.Color.IndianRed;
            this.lbtax.Location = new System.Drawing.Point(334, 306);
            this.lbtax.Name = "lbtax";
            this.lbtax.Size = new System.Drawing.Size(34, 20);
            this.lbtax.TabIndex = 0;
            this.lbtax.Text = "Tax";
            this.lbtax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbtax.Click += new System.EventHandler(this.lbtax_Click);
            // 
            // lblastsalary
            // 
            this.lblastsalary.AutoSize = true;
            this.lblastsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblastsalary.ForeColor = System.Drawing.Color.IndianRed;
            this.lblastsalary.Location = new System.Drawing.Point(334, 360);
            this.lblastsalary.Name = "lblastsalary";
            this.lblastsalary.Size = new System.Drawing.Size(88, 20);
            this.lblastsalary.TabIndex = 0;
            this.lblastsalary.Text = "Last Salary";
            // 
            // TaxSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtchil);
            this.Controls.Add(this.txtspouse);
            this.Controls.Add(this.txtbonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblastsalary);
            this.Controls.Add(this.lbtax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaxSalary";
            this.Text = "TaxSalary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtspouse;
        private System.Windows.Forms.TextBox txtchil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtax;
        private System.Windows.Forms.Label lblastsalary;
    }
}