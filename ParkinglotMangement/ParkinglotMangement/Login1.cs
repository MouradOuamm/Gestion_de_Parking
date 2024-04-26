using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace ParkinglotMangement
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Show_Password_CheckedChanged(object sender, EventArgs e)

        {
            if (Show_Password.Checked == true)
            {
                Password_login1.UseSystemPasswordChar = false;
            }
            else
            {
                Password_login1.UseSystemPasswordChar = true;

            }
        }

        private void guna2TextBox2_IconRightClick(object sender, EventArgs e)
        {
            if(Password_login1.UseSystemPasswordChar)
            {
                Password_login1.UseSystemPasswordChar = false;
                Password_login1.IconRight = Properties.Resources.eye__1_;
            }
            else
            {
                Password_login1.UseSystemPasswordChar = true;
                Password_login1.IconRight = Properties.Resources.eye__1_;
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (Password_login1.Text == "" || User_Name1.Text == "")
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                if (Password_login1.Text == "admin" && User_Name1.Text == "admin")
                {
                    Cars obj = new Cars();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password ");
                    User_Name1.Text = "";
                    Password_login1.Text = "";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("file:///C:/Users/Republic%20Of%20Computer/Desktop/Mini%20Projet/ParkinglotMangement/ParkinglotMangement/HTMLPage1.html");
            
            
        }
    }
}

