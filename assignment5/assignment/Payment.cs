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
    public partial class combo_card : Form
    {
        private String id;
        private String name;
        private String contact;
        private String address;
        private String tprice;
        public combo_card(String id, String name, String con,String add, String p) 
        {

            this.name = name;
            this.contact = con;
            this.address = add;
            this.tprice = p;
            this.id = id;
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.Visible = true;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "12345")
            {
                MessageBox.Show("order successfully");
            }
            else
            {
                MessageBox.Show("pin in incorrected");
            }
        }

        private void combo_card_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = this.id;
            lbl_name.Text = this.name;
            lbl_contact.Text = this.contact;
            lbl_address.Text = this.address;
            lbl_totalpayment.Text = this.tprice;

        }
    }
}
