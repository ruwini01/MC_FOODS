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
    public partial class frmPOS : Form
    {
        Functions Con;
        public frmPOS()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int Key = 0;
        int price = 0;

       

        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1)
            {
                Pizza = "Small";
            }
            else if (Key == 2)
            {
                Pizza = "Medium";
            }
            else if (Key == 3)
            {
                Pizza = "Large";
            }
            else if (Key == 4)
            {
                Pizza = "Extra Large";
            }
            string Query = "select * from PizzaTbl where Item = '{0}'";
            Query = string.Format(Query,Pizza);
            price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
        }
        int n = 0;
        string Items;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (SmallBtn.Checked == true)
            {
                Key = 1;
                Items = "Small Pizza";
            }
            else if(MediumBtn.Checked == true)
            {
                Key = 2;
                Items = "Medium Pizza";
            }
            else if (LargeBtn.Checked == true)
            {
                Key = 3;
                Items = "Large Pizza";
            }
            else if (ExtraLargeBtn.Checked == true)
            {
                Key = 4;
                Items = "Extra Large Pizza";
            }

            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTB.Text);
            int total = Qty * price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = price;
            newRow.Cells[3].Value = QtyTB.Text;
            newRow.Cells[4].Value = total;

        }
    }
}
