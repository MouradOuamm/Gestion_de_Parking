using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkinglotMangement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Exiter()
        {
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Exiter();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Password_Login.UseSystemPasswordChar = true;
        }



        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(Show_Password.Checked == true)
            {
                Password_Login.UseSystemPasswordChar = false;
            }
            else
            {
                Password_Login.UseSystemPasswordChar = true;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Password_Login.Text == "" || Username_Login.Text == "")
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                if (Password_Login.Text == "admin" && Username_Login.Text == "admin")
                {
                  //  Cars obj = new Cars();
                    //obj.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password ");
                    Username_Login.Text = "";
                    Password_Login.Text = "";
                }
            }
        }
    }
}
