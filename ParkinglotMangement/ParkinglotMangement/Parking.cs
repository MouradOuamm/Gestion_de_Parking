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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
            con = new Functions();
            GetCars();
            GetPlaces();
            ShowBooking();
        }
        public void Exiter()
        {
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parking_Load(object sender, EventArgs e)
        {
            
         
              
        }
        Functions con;
        private void GetCars()
        {
            String Query = "Select * from CarsTb1";
            CarsParking.ValueMember = con.GetData(Query).Columns["CNum"].ToString();
            CarsParking.DisplayMember = con.GetData(Query).Columns["PNumber"].ToString();
            CarsParking.DataSource = con.GetData(Query);
        }
        private void GetPlaces()
        {
            string pst = "free";
            String Query = "Select * from PlaceTb1  ";
            Query = string.Format(Query, pst);
            PlaceParking.ValueMember = con.GetData(Query).Columns["PlNum"].ToString();
            PlaceParking.DisplayMember = con.GetData(Query).Columns["Ppositioh"].ToString();
            PlaceParking.DataSource = con.GetData(Query);
        }
        private void ShowBooking()
        {
            String Query = "Select * from ParkingTb1";
            ParkingDGV.DataSource = con.GetData(Query);
        }
        private void UpdateStatus()
        {
            try
            {

                string Pst ="Booked";
                string Place = PlaceParking.SelectedItem.ToString();
                string Query = " update   PlaceTb1  set PStatus ='{0}' where PINum = {1} ";
                Query = string.Format(Query, Pst,Place);
                MessageBox.Show(" Updated  !!! ");
           
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
    
        private void BookPlace_Parking_Click(object sender, EventArgs e)
        {
            if (CarsParking.SelectedIndex == -1  || PlaceParking.SelectedIndex == -1  || DurationParking.Text == "" || AmountParking.Text == "" )
            {
                MessageBox.Show("Missed Data !! ");
            }
            else
            {
                try
                {
                    string Car = CarsParking.SelectedValue.ToString();
                    int Duration = Convert.ToInt32(DurationParking.Text);
                    int amount = Convert.ToInt32(AmountParking.Text);
                    string Place = PlaceParking.SelectedValue.ToString();
                    string Datee = System.DateTime.Today.ToString();
                    string Query = "insert into ParkingTb1 (Car,Duration,Datee,Amount,Place) values ('" + Car + "'," + Duration + ",'"+Datee+"'," + amount + "," + Place + ")";
                    Query = string.Format(Query, Car, Duration, Datee, amount, Place);
                    con.SetData(Query);
                    MessageBox.Show("Place  Booked !! ");
                    ShowBooking();
                    UpdateStatus();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cars obj = new Cars();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Places obj = new Places();
            obj.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Parking obj = new Parking();
            obj.Hide();
            obj.Show();
            
        }

        private void PlaceParking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cars_Afficher_Click(object sender, EventArgs e)
        {
            Cars obj = new Cars();
            obj.Show();
            obj.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you want to exit Application ?", "Exit Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void L1R1_P_Click(object sender, EventArgs e)
        {

        }

        private void L2R1_P_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
