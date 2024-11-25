namespace lab1
{
    partial class frmordline
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
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(66, 112);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(50, 20);
            this.lblqty.TabIndex = 0;
            this.lblqty.Text = "Qty = ";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(176, 112);
            this.txtqty.Multiline = true;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(193, 27);
            this.txtqty.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(396, 157);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(143, 29);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price = ";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(176, 157);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(193, 29);
            this.txtprice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total = ";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(176, 206);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txttotal.Size = new System.Drawing.Size(363, 171);
            this.txttotal.TabIndex = 1;
            // 
            // frmordline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 411);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblqty);
            this.Name = "frmordline";
            this.Text = "frmordline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
    }
}