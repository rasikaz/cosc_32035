using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace practical4
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Information.IsNumeric(txt_mark.Text) && double.Parse(txt_mark.Text)<=100 && double.Parse(txt_mark.Text) >= 0)
            {
                if (double.Parse(txt_mark.Text) < 40)
                    MessageBox.Show("Fail");
                else if (double.Parse(txt_mark.Text) < 50)
                    MessageBox.Show("Pass");
                else if (double.Parse(txt_mark.Text) < 60)
                    MessageBox.Show("Credit Pass");
                else
                    MessageBox.Show("Distinction Pass");
            }
            else
            {
                MessageBox.Show("Something Went Wrong Please Check again");
            }

            txt_mark.Text = "";
            
        }
    }
}
