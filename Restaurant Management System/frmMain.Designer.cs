namespace Restaurant_Management_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Restaurant_Management_System.GradientPanel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.btnpos = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnProducts = new Guna.UI.WinForms.GunaButton();
            this.buttonCategories = new Guna.UI.WinForms.GunaButton();
            this.buttonDashboard = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 37);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 10;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(853, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 32);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.label5);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(173, 37);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(727, 463);
            this.CenterPanel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(128, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(470, 48);
            this.label5.TabIndex = 23;
            this.label5.Text = "Welcome To McFood ";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 20F;
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(88)))));
            this.gradientPanel2.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.gunaButton5);
            this.gradientPanel2.Controls.Add(this.gunaButton6);
            this.gradientPanel2.Controls.Add(this.btnpos);
            this.gradientPanel2.Controls.Add(this.gunaButton3);
            this.gradientPanel2.Controls.Add(this.gunaButton4);
            this.gradientPanel2.Controls.Add(this.btnProducts);
            this.gradientPanel2.Controls.Add(this.buttonCategories);
            this.gradientPanel2.Controls.Add(this.buttonDashboard);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.pictureBox2);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 37);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(173, 463);
            this.gradientPanel2.TabIndex = 22;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(73)))));
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(16, 370);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 20;
            this.gunaButton5.Size = new System.Drawing.Size(120, 34);
            this.gunaButton5.TabIndex = 16;
            this.gunaButton5.Text = "settings";
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.gunaButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton6.Image")));
            this.gunaButton6.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton6.Location = new System.Drawing.Point(16, 332);
            this.gunaButton6.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 20;
            this.gunaButton6.Size = new System.Drawing.Size(120, 34);
            this.gunaButton6.TabIndex = 15;
            this.gunaButton6.Text = "Kitchen";
            // 
            // btnpos
            // 
            this.btnpos.AnimationHoverSpeed = 0.07F;
            this.btnpos.AnimationSpeed = 0.03F;
            this.btnpos.BackColor = System.Drawing.Color.Transparent;
            this.btnpos.BaseColor = System.Drawing.Color.Transparent;
            this.btnpos.BorderColor = System.Drawing.Color.Transparent;
            this.btnpos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnpos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.btnpos.Image = ((System.Drawing.Image)(resources.GetObject("btnpos.Image")));
            this.btnpos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnpos.Location = new System.Drawing.Point(16, 294);
            this.btnpos.Margin = new System.Windows.Forms.Padding(2);
            this.btnpos.Name = "btnpos";
            this.btnpos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnpos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnpos.OnHoverImage = null;
            this.btnpos.OnPressedColor = System.Drawing.Color.Black;
            this.btnpos.Radius = 20;
            this.btnpos.Size = new System.Drawing.Size(120, 34);
            this.btnpos.TabIndex = 14;
            this.btnpos.Text = "POS";
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click_1);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton3.Location = new System.Drawing.Point(16, 256);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 20;
            this.gunaButton3.Size = new System.Drawing.Size(120, 34);
            this.gunaButton3.TabIndex = 13;
            this.gunaButton3.Text = "Staff";
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(16, 221);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 20;
            this.gunaButton4.Size = new System.Drawing.Size(120, 34);
            this.gunaButton4.TabIndex = 12;
            this.gunaButton4.Text = "Tables";
            // 
            // btnProducts
            // 
            this.btnProducts.AnimationHoverSpeed = 0.07F;
            this.btnProducts.AnimationSpeed = 0.03F;
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BaseColor = System.Drawing.Color.Transparent;
            this.btnProducts.BorderColor = System.Drawing.Color.Transparent;
            this.btnProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProducts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProducts.Location = new System.Drawing.Point(16, 183);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProducts.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProducts.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProducts.OnHoverImage = null;
            this.btnProducts.OnPressedColor = System.Drawing.Color.Black;
            this.btnProducts.Radius = 20;
            this.btnProducts.Size = new System.Drawing.Size(120, 34);
            this.btnProducts.TabIndex = 11;
            this.btnProducts.Text = "Products";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_1);
            // 
            // buttonCategories
            // 
            this.buttonCategories.AnimationHoverSpeed = 0.07F;
            this.buttonCategories.AnimationSpeed = 0.03F;
            this.buttonCategories.BackColor = System.Drawing.Color.Transparent;
            this.buttonCategories.BaseColor = System.Drawing.Color.Transparent;
            this.buttonCategories.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.buttonCategories.Image = ((System.Drawing.Image)(resources.GetObject("buttonCategories.Image")));
            this.buttonCategories.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonCategories.Location = new System.Drawing.Point(16, 145);
            this.buttonCategories.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCategories.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonCategories.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonCategories.OnHoverImage = null;
            this.buttonCategories.OnPressedColor = System.Drawing.Color.Black;
            this.buttonCategories.Radius = 20;
            this.buttonCategories.Size = new System.Drawing.Size(120, 34);
            this.buttonCategories.TabIndex = 10;
            this.buttonCategories.Text = "Categories";
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.AnimationHoverSpeed = 0.07F;
            this.buttonDashboard.AnimationSpeed = 0.03F;
            this.buttonDashboard.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonDashboard.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonDashboard.Location = new System.Drawing.Point(16, 110);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonDashboard.OnHoverImage = null;
            this.buttonDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.buttonDashboard.Radius = 20;
            this.buttonDashboard.Size = new System.Drawing.Size(128, 34);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Restaurant \r\nManagement System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private GradientPanel gradientPanel2;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton btnpos;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton btnProducts;
        private Guna.UI.WinForms.GunaButton buttonCategories;
        private Guna.UI.WinForms.GunaButton buttonDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label label5;
    }
}