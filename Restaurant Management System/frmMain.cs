using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class frmMain : Form
    {
        

        FormLogin login = new FormLogin();
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(FormLogin l)
        {
            login = l;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome "+FormLogin.uname;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonCategories_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void buttonProducts_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonTables_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonStaff_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonPOS_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonKitchen_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonReports_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonSetting_Click_1(object sender, EventArgs e)
        {
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e, FormLogin formLogin)
        {
            string USER = formLogin.textBoxUsername.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
