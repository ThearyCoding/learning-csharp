namespace C__Sql_Server
{
    partial class FrmLuckyDraw
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
            this.components = new System.ComponentModel.Container();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtgenerate = new System.Windows.Forms.TextBox();
            this.dgvpeople = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstwinner = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(280, 37);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(197, 38);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtgenerate
            // 
            this.txtgenerate.Location = new System.Drawing.Point(48, 37);
            this.txtgenerate.Multiline = true;
            this.txtgenerate.Name = "txtgenerate";
            this.txtgenerate.Size = new System.Drawing.Size(211, 38);
            this.txtgenerate.TabIndex = 1;
            // 
            // dgvpeople
            // 
            this.dgvpeople.AllowUserToAddRows = false;
            this.dgvpeople.AllowUserToDeleteRows = false;
            this.dgvpeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.gender,
            this.email});
            this.dgvpeople.Location = new System.Drawing.Point(280, 112);
            this.dgvpeople.Name = "dgvpeople";
            this.dgvpeople.ReadOnly = true;
            this.dgvpeople.Size = new System.Drawing.Size(547, 332);
            this.dgvpeople.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // lstwinner
            // 
            this.lstwinner.FormattingEnabled = true;
            this.lstwinner.Location = new System.Drawing.Point(48, 112);
            this.lstwinner.Name = "lstwinner";
            this.lstwinner.Size = new System.Drawing.Size(211, 329);
            this.lstwinner.TabIndex = 3;
            this.lstwinner.SelectedIndexChanged += new System.EventHandler(this.lstwinner_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 494);
            this.Controls.Add(this.lstwinner);
            this.Controls.Add(this.dgvpeople);
            this.Controls.Add(this.txtgenerate);
            this.Controls.Add(this.btnstart);
            this.Name = "FrmLuckyDraw";
            this.Text = "FrmLuckyDraw";
            this.Load += new System.EventHandler(this.FrmLuckyDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtgenerate;
        private System.Windows.Forms.DataGridView dgvpeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.ListBox lstwinner;
        private System.Windows.Forms.Timer timer1;
    }
}