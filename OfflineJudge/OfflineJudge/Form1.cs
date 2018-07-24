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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-SE1LGSL\\SQLEXPRESS;Initial Catalog=OJDB;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user_id = useridBox.Text;
            String password = passwordBox.Text;
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand selectCommand = new SqlCommand(" Select * from reg where userid = '" + user_id + "' and password ='" + password + "'", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();
            if (dataFromDb.HasRows)
            {
                MessageBox.Show("Login Succesful");
                this.Hide();
                Problemset ct = new Problemset();
                ct.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Email or/and Password is wrong");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
