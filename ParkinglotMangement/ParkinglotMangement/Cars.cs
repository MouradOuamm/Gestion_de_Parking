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
    public partial class Cars : Form
    {
        Functions con;
        public Cars()
        {
            InitializeComponent();
            con = new Functions();
            ShowCars();
        }
        public void Exiter()
        {
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void ShowCars()
        {
            string Query = "Select * from CarsTb1";
            CarsDGV.DataSource = con.GetData(Query);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Cars_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(Plat_Number.Text == "" || DriverT.Text =="" || GendreC.Text == ""|| Car_Type.Text =="" || ColorT.Text =="")
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                {
                    string PNumber = Plat_Number.Text;
                    string Driver = DriverT.Text;
                    string Gendre = GendreC.SelectedItem.ToString();
                    string CType = Car_Type.Text;
                    string Color = ColorT.Text;
                    string Query = "insert  into CarsTb1 (PNumber,Driver,Gender,CarType,CarColor) values ('"+PNumber+"','"+Driver+"','"+Gendre+"','"+CType+"','"+Color+"')";
                    Query = string.Format(Query, PNumber, Driver, Gendre, CType, Color );
                    con.SetData(Query);
                    MessageBox.Show("Car Added !! ");
                    ShowCars();
                }
                catch (Exception Ex) 
                {

                    MessageBox.Show(Ex.Message);

                }
            }
        }
        int key = 0;
        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (Plat_Number.Text == "" || DriverT.Text == "" || GendreC.Text == "" || Car_Type.Text == "" || ColorT.Text == "" || key == 0)
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                {

                    string PNumber = Plat_Number.Text;
                    string Driver = DriverT.Text;
                    string Car = Car_Type.Text;
                    string Color = ColorT.Text;
                    string Gendre = GendreC.SelectedItem.ToString();
                    string Query = " Update CarsTb1 set  PNumber = '"+ PNumber + "',Driver ='"+Driver+"',Gender ='"+Gendre+"',CarType ='"+Car+"',CarColor ='"+Color+"' where CNum = "+ CarsDGV.SelectedRows[0].Cells[0].Value.ToString() + "";
                    Query = string.Format(Query, PNumber, Driver, Car, Color, Gendre );
                    MessageBox.Show("Car Updated !! ");
                    ShowCars();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (key == 0 )
            {
                MessageBox.Show("Select a car  !! ");
            }
            else
            {
                try
                {
                    string Query = " delete from  CarsTb1  where CNum =" + Convert.ToInt32(CarsDGV.SelectedRows[0].Cells[0].Value.ToString()) + " ";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    MessageBox.Show("Car Deleted !! ");
                    ShowCars();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Parking obj = new Parking();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)

        {
            Exiter();
        }


        private void DriverT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Plat_Number.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DriverT.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            GendreC.SelectedItem = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Car_Type.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
            ColorT.Text = CarsDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (Plat_Number.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CarsDGV.SelectedRows[0].Cells[0].Value);
            }
        }

        private void CarsDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Places obj = new Places();
            obj.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

    
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Plat_Number.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DriverT.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            GendreC.SelectedItem = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Car_Type.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
            ColorT.Text = CarsDGV.SelectedRows[0].Cells[5].Value.ToString();
            MessageBox.Show(Plat_Number.Text);

            if (Plat_Number.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CarsDGV.SelectedRows[0].Cells[0].Value);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Exiter();
        }
    }
    }

