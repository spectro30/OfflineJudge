using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfflineJudge
{
    public partial class Problemset : Form
    {
        public Problemset()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-SE1LGSL\\SQLEXPRESS;Initial Catalog=OJDB;Integrated Security=True";

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Categories_Load(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lets Consider F(N) is the Nth Fibonacci number.\nYou will be given the value of N.\nCalculate F(F(N))\n\nF(0) = 0\nF(1) = 1\nSo, F(F(1)) = 1");
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lets Consider F(N) is the Nth Fibonacci number.\nYou will be given the value of N.\nCalculate F(F(N))\n\nF(0) = 0\nF(1) = 1\nSo, F(F(1)) = 1");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Close();
            submit s = new submit();
            s.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

        }
    }
}
