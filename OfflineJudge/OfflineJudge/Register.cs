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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-SE1LGSL\\SQLEXPRESS;Initial Catalog=OJDB;Integrated Security=True";
        private void password_OnValueChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void userid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user_id = name.Text;
            String country = CountryDropDown.selectedValue;
            String institution = institutionlist.selectedValue;
            String email = emailBox.Text;
            String password = passwordBox.Text;
            String repassword = repasswordBox.Text;

            int cnt1 = 0;

            if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Please Enter an Valid Email Adress");
            }
            else cnt1++;

            if (!System.Text.RegularExpressions.Regex.IsMatch(name.Text, "[A-Z]"))
            {
                MessageBox.Show("Please Use Lower Case Letters As Well");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name.Text, "[a-z]"))
            {
                MessageBox.Show("Please Use Uoper Case Letters As Well");
            }
            else cnt1++;
            
            if (password != repassword)
            {
                MessageBox.Show("Password Dosen't Matched");
            }
            else cnt1 ++;
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Password must contain number, letter and special character");
            }
            else cnt1 ++;
            
            if(cnt1 == 4){
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand insertCommand = new SqlCommand("insert into reg(userid,country,institution,email,password) values ('" + user_id + "','" + country + "','" + institution + "','" + email + "','" + password + "') ", connection);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Congrats, " + user_id + " Registration Successful");
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
            }
            

        }

        private void OJLogo_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CountryDropDown_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
