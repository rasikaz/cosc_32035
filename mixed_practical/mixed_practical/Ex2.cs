using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mixed_practical
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eval_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txt_age.Text);
            int rating = int.Parse(txt_rating.Text);

            if (age > 20)
            {
                if (rating > 6)
                    MessageBox.Show("You can drive along this road, permission");
                else
                    MessageBox.Show("It is not safe to you to drive in this lane, permission");
            }
            else
            {
                MessageBox.Show("Sorry, ypo are too young to drive, permission");
            }
        }
    }
}
