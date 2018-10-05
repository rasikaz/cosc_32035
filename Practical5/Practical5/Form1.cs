using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, sum = 0, i = 1;

            num = int.Parse(txt_number.Text);
            while (i <= num) {
                sum += i;
                i++;
            }

            MessageBox.Show("sum of first "+num+" natural number is "+sum+" sum");
        }
    }
}
