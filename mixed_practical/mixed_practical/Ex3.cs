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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void Ex3_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Geek Glasses");
            checkedListBox1.Items.Add("fancy Sum Glasses");
            checkedListBox1.Items.Add("Heart Sum Glasses");
            checkedListBox1.Items.Add("Business Outfit");
            checkedListBox1.Items.Add("Fitness Outfit");
            checkedListBox1.Items.Add("Cocktail Dress");
            checkedListBox1.Items.Add("Hat");
            checkedListBox1.Items.Add("Tiara");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int x, y = 0;
            x = checkedListBox1.CheckedItems.Count - 1;
            textBox1.Text = "Your Oder Items " + Environment.NewLine;

            for(; y <=x; y++)
            {
                textBox1.Text = textBox1.Text + checkedListBox1.CheckedItems[y].ToString() + Environment.NewLine;
            }
        }
    }
}
