using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
     
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_address.Visible = false;

        }

        private double load_total_price()
        {
            double sum = 0;
            foreach(DataGridViewRow row in datagrideView.Rows)
            {
                sum += Convert.ToDouble(row.Cells["colPrice"].Value);
            }

            return sum;
        }

        private void comboCate_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboItem.Items.Clear();
            comboItem.Text = "";
            if (comboCate.Text == "Category1")
            {
                comboItem.Items.Add("Item1.1");
                comboItem.Items.Add("Item1.2");
                comboItem.Items.Add("Item1.3");
                comboItem.Items.Add("Item1.4");
            }
            else if (comboCate.Text == "Category2")
            {
                comboItem.Items.Add("Item2.1");
                comboItem.Items.Add("Item2.2");
                comboItem.Items.Add("Item2.3");
                comboItem.Items.Add("Item2.4");
                comboItem.Items.Add("Item2.5");
            }
            else if (comboCate.Text == "Category3")
            {
                comboItem.Items.Add("Item3.1");
                comboItem.Items.Add("Item3.2");
                comboItem.Items.Add("Item3.3");
                comboItem.Items.Add("Item3.4");
                comboItem.Items.Add("Item3.5");
            }
            else if (comboCate.Text == "Category4")
            {
                comboItem.Items.Add("Item4.1");
                comboItem.Items.Add("Item4.2");
                comboItem.Items.Add("Item4.3");
                comboItem.Items.Add("Item4.4");
                comboItem.Items.Add("Item4.5");
            }
            else if (comboCate.Text == "Category5")
            {
                comboItem.Items.Add("Item5.1");
                comboItem.Items.Add("Item5.2");
                comboItem.Items.Add("Item5.3");
                comboItem.Items.Add("Item5.4");
                comboItem.Items.Add("Item5.5");
            }
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        static int indexno =0;

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(comboCate.Text) || String.IsNullOrEmpty(comboItem.Text) || String.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("There are/is Empty field/s");
                return;
            }


            int cate =comboCate.SelectedIndex;
            int item = comboItem.SelectedIndex;
            int qty = Convert.ToInt32( txtQty.Text);

            Price price = new Price();

            lblPrice.Text ="RS." +(price.price_list[cate,item]*qty).ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            indexno++;
            String item = comboItem.Text;
            double up = Convert.ToDouble(lblPrice.Text.Substring(3) )/ Convert.ToDouble(txtQty.Text);
            String qty = txtQty.Text;
            String price = lblPrice.Text.Substring(3);

            String[] row = {indexno.ToString(), item,up.ToString(),qty,price };
            datagrideView.Rows.Add(row);
            comboCate.SelectedIndex = -1;
            comboItem.SelectedIndex = -1;
            txtQty.Text = "";
            lblPrice.Text = "RS,0";
            lbi_total_price.Text = "Total Price is " + load_total_price();
        }

        private void btnGotoCart_Click(object sender, EventArgs e)
        {

            lbi_total_price.Text = "Total Price is " + load_total_price();
            txt_address.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //order page

            //select place
            int sindex = datagrideView.CurrentCell.RowIndex;

            datagrideView.Rows.RemoveAt(sindex);
            lbi_total_price.Text = "Total Price is " + load_total_price();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            combo_card f = new combo_card(txtID.Text, txtName.Text,txtContact.Text,text_address.Text, lbi_total_price.Text);
            f.Visible = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
             Form1 f = new Form1();
            f.Visible = true;
        }
    }
}
