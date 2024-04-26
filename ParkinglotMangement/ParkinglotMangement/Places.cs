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
    public partial class Places : Form
    {
        public Places()
        {
            InitializeComponent();
            con = new Functions();
            ShowPlace();
        }
        public void Exiter()
        {
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        Functions con;
        private void ShowPlace()
        {
            string Query = "select *from PlaceTb1";
            PlaceDGV.DataSource = con.GetData(Query);
        }


        private void Add_btn_Plac_Click(object sender, EventArgs e)
        {
            if (PositionP.Text == "" || StatusP.SelectedIndex == -1)
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                { 
                    string Position = PositionP.Text;
                    string Stat = StatusP.SelectedItem.ToString();
                    string Query = "INSERT INTO PlaceTb1 (Ppositioh,PStatus)  VALUES('"+Position+"', '"+Stat+"')";
                    Query = string.Format(Query, Position, Stat);
                    con.SetData(Query);
                    MessageBox.Show("Place Added !! ");
                    ShowPlace();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }
    }
        int key = 0;

       
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (PositionP.Text == "" || StatusP.SelectedIndex ==-1)
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                {

                    string Position = PositionP.Text;
                    string stat = StatusP.SelectedItem.ToString();
                   string Query = "Update PlaceTb1 Set Ppositioh='" + Position+ "',PStatus='" + stat + "'where PlNum="+ Convert.ToInt32(PlaceDGV.SelectedRows[0].Cells[0].Value.ToString())+ "";
                    Query = string.Format(Query, Position, stat, key);
                    con.SetData(Query);
                    MessageBox.Show("Place Updated !! ");
                    ShowPlace();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void Dele_btn_car_Click(object sender, EventArgs e)
        {
            if (PositionP.Text == "" || StatusP.SelectedIndex == -1)
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                {

                    string Position = PositionP.Text;
                    string stat = StatusP.SelectedItem.ToString();
                    string Query = " delete from  PlaceTb1  where PlNum =" + Convert.ToInt32(PlaceDGV.SelectedRows[0].Cells[0].Value.ToString()) +" ";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    MessageBox.Show("Place Deteted !! ");
                    ShowPlace();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Exiter();

        }

        private void Places_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Exiter();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cars obj = new Cars();
            obj.Show();
            this.Hide();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Parking obj = new Parking() ;
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlaceDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PositionP.Text = PlaceDGV.SelectedRows[0].Cells[1].Value.ToString();
            StatusP.SelectedItem = PlaceDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (PositionP.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PlaceDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Exiter();

        }
    }
    }

    

