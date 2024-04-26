using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ParkinglotMangement
{
    public partial class Loading : Form
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr  CreateRoundRectRgn
        (
            int nleft,
            int nleft1,
            int nleft2,
            int nleft3,
            int nlef4,
            int nleft5

        );
        public Loading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width,Height,25,25));
            ProgressBar1.Value = 0;
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%"; 
            if(ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Login1 log = new Login1();
                log.Show();
                this.Hide();

            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
