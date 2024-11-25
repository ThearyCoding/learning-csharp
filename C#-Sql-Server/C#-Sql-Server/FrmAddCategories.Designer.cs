namespace C__Sql_Server
{
    partial class FrmAddCategories
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
            this.txtcname = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.datagridcategories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name : ";
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(207, 57);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(214, 26);
            this.txtcname.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(145, 107);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 35);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Back";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(294, 107);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(127, 35);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Record";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // datagridcategories
            // 
            this.datagridcategories.AllowUserToAddRows = false;
            this.datagridcategories.AllowUserToDeleteRows = false;
            this.datagridcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.datagridcategories.Location = new System.Drawing.Point(16, 164);
            this.datagridcategories.Name = "datagridcategories";
            this.datagridcategories.ReadOnly = true;
            this.datagridcategories.Size = new System.Drawing.Size(405, 322);
            this.datagridcategories.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CategoryId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 498);
            this.Controls.Add(this.datagridcategories);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddCategories";
            this.Text = "FrmAddCategories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddCategories_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView datagridcategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}