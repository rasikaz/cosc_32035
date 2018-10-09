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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            switch(index)
            {
                case 0 : pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; break;
                case 1 : pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case 2: pictureBox1.SizeMode = PictureBoxSizeMode.Normal; break;
                case 3: pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case 4: pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; break;
            }
        }
    }
}
