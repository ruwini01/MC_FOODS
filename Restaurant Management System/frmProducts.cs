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
    public partial class frmProducts : Form
    {
        Functions Con;
        public frmProducts()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
                int Pr = Convert.ToInt32(PriceTb.Text);

                if (PriceTb.Text == "")
                {
                    MessageBox.Show("Please Enter a Price");
                }
                
                if (PizzaCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select a Pizza");
                } 
                else if (PizzaCb.SelectedIndex == 0)
                {
                    Key = "Extra Large";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query,Pr,Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated");
                }
                else if (PizzaCb.SelectedIndex == 1)
                {
                    Key = "Large";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated");
                }
                else if (PizzaCb.SelectedIndex == 2)
                {
                    Key = "Medium";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated");
                }
                else if (PizzaCb.SelectedIndex == 3)
                {
                    Key = "Small";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated");
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
