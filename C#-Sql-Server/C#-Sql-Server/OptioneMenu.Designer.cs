namespace C__Sql_Server
{
    partial class OptioneMenu
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
            this.btnpeople = new System.Windows.Forms.Button();
            this.btngotolucky = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.btngocategories = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpeople
            // 
            this.btnpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpeople.Location = new System.Drawing.Point(28, 146);
            this.btnpeople.Name = "btnpeople";
            this.btnpeople.Size = new System.Drawing.Size(286, 67);
            this.btnpeople.TabIndex = 0;
            this.btnpeople.Text = "View People";
            this.btnpeople.UseVisualStyleBackColor = true;
            this.btnpeople.Click += new System.EventHandler(this.btnpeople_Click);
            // 
            // btngotolucky
            // 
            this.btngotolucky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngotolucky.Location = new System.Drawing.Point(28, 62);
            this.btngotolucky.Name = "btngotolucky";
            this.btngotolucky.Size = new System.Drawing.Size(286, 54);
            this.btngotolucky.TabIndex = 1;
            this.btngotolucky.Text = "Go to Form Lucky";
            this.btngotolucky.UseVisualStyleBackColor = true;
            this.btngotolucky.Click += new System.EventHandler(this.btngotolucky_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.Location = new System.Drawing.Point(28, 243);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(286, 64);
            this.btnaddproduct.TabIndex = 2;
            this.btnaddproduct.Text = "Go to Add Product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btngocategories
            // 
            this.btngocategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngocategories.Location = new System.Drawing.Point(389, 62);
            this.btngocategories.Name = "btngocategories";
            this.btngocategories.Size = new System.Drawing.Size(212, 54);
            this.btngocategories.TabIndex = 3;
            this.btngocategories.Text = "Go to Categories";
            this.btngocategories.UseVisualStyleBackColor = true;
            this.btngocategories.Click += new System.EventHandler(this.btngocategories_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go to Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptioneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngocategories);
            this.Controls.Add(this.btnaddproduct);
            this.Controls.Add(this.btngotolucky);
            this.Controls.Add(this.btnpeople);
            this.Name = "OptioneMenu";
            this.Text = "OptioneMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptioneMenu_FormClosed);
            this.Load += new System.EventHandler(this.OptioneMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpeople;
        private System.Windows.Forms.Button btngotolucky;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.Button btngocategories;
        private System.Windows.Forms.Button button1;
    }
}