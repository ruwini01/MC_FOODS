namespace Restaurant_Management_System
{
    partial class frmPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtraLargeBtn = new System.Windows.Forms.RadioButton();
            this.LargeBtn = new System.Windows.Forms.RadioButton();
            this.MediumBtn = new System.Windows.Forms.RadioButton();
            this.SmallBtn = new System.Windows.Forms.RadioButton();
            this.QtyTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExtraLargeBtn);
            this.panel1.Controls.Add(this.LargeBtn);
            this.panel1.Controls.Add(this.MediumBtn);
            this.panel1.Controls.Add(this.SmallBtn);
            this.panel1.Location = new System.Drawing.Point(17, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 196);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Pizza size";
            // 
            // ExtraLargeBtn
            // 
            this.ExtraLargeBtn.AutoSize = true;
            this.ExtraLargeBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLargeBtn.Location = new System.Drawing.Point(17, 132);
            this.ExtraLargeBtn.Name = "ExtraLargeBtn";
            this.ExtraLargeBtn.Size = new System.Drawing.Size(114, 25);
            this.ExtraLargeBtn.TabIndex = 0;
            this.ExtraLargeBtn.TabStop = true;
            this.ExtraLargeBtn.Text = "Extra Large";
            this.ExtraLargeBtn.UseVisualStyleBackColor = true;
            // 
            // LargeBtn
            // 
            this.LargeBtn.AutoSize = true;
            this.LargeBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeBtn.Location = new System.Drawing.Point(17, 109);
            this.LargeBtn.Name = "LargeBtn";
            this.LargeBtn.Size = new System.Drawing.Size(70, 25);
            this.LargeBtn.TabIndex = 0;
            this.LargeBtn.TabStop = true;
            this.LargeBtn.Text = "Large";
            this.LargeBtn.UseVisualStyleBackColor = true;
            // 
            // MediumBtn
            // 
            this.MediumBtn.AutoSize = true;
            this.MediumBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBtn.Location = new System.Drawing.Point(17, 86);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(89, 25);
            this.MediumBtn.TabIndex = 0;
            this.MediumBtn.TabStop = true;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = true;
            // 
            // SmallBtn
            // 
            this.SmallBtn.AutoSize = true;
            this.SmallBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallBtn.Location = new System.Drawing.Point(17, 63);
            this.SmallBtn.Name = "SmallBtn";
            this.SmallBtn.Size = new System.Drawing.Size(69, 25);
            this.SmallBtn.TabIndex = 0;
            this.SmallBtn.TabStop = true;
            this.SmallBtn.Text = "Small";
            this.SmallBtn.UseVisualStyleBackColor = true;
            // 
            // QtyTB
            // 
            this.QtyTB.Location = new System.Drawing.Point(92, 273);
            this.QtyTB.Name = "QtyTB";
            this.QtyTB.Size = new System.Drawing.Size(73, 20);
            this.QtyTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordering System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // BillDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillDGV.ColumnHeadersHeight = 21;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.Location = new System.Drawing.Point(196, 48);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersVisible = false;
            this.BillDGV.Size = new System.Drawing.Size(336, 256);
            this.BillDGV.TabIndex = 2;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.ThemeStyle.HeaderStyle.Height = 21;
            this.BillDGV.ThemeStyle.ReadOnly = false;
            this.BillDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDGV.ThemeStyle.RowsStyle.Height = 22;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(17, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 5);
            this.panel3.TabIndex = 18;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderBtn.FlatAppearance.BorderSize = 2;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.Color.White;
            this.OrderBtn.Location = new System.Drawing.Point(36, 309);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(134, 40);
            this.OrderBtn.TabIndex = 19;
            this.OrderBtn.Text = "AddOrder";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintBtn.FlatAppearance.BorderSize = 2;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(259, 309);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(134, 40);
            this.PrintBtn.TabIndex = 20;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 463);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BillDGV);
            this.Controls.Add(this.QtyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Text = "FrmPOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SmallBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ExtraLargeBtn;
        private System.Windows.Forms.RadioButton LargeBtn;
        private System.Windows.Forms.RadioButton MediumBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button PrintBtn;
    }
}