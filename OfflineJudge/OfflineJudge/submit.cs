using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineJudge
{
    public partial class submit : Form
    {
        public submit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            string i1 = input1.Text;
            string i2 = input2.Text;
            string i3 = input3.Text;
            if (i1 == "0" && i2 == "1" && i3 == "3524578")
            {
                MessageBox.Show("Wohoo!!!\nYour Solution is Accepted\n");
                this.Close();
                Problemset p = new Problemset();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wriong Answer\nHold on, You can do it !!! \n");
            }

        }
    }
}
