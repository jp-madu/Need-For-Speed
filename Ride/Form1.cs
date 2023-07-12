using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ride
{
    public partial class Form1 : Form
    {
        int Speed = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ride4_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Ride2.Visible = false;
            Ride3.Visible = false;
            Ride4.Visible = false;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void btnGear1_Click(object sender, EventArgs e)
        {
            Speed = 20;
        }

        private void btnGear2_Click(object sender, EventArgs e)
        {
            Speed = 30;
        }

        private void btnGear3_Click(object sender, EventArgs e)
        {
            Speed = 40;
        }

        private void btnGear4_Click(object sender, EventArgs e)
        {
            Speed = 50;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            Ride1.Visible = true;
            Ride2.Visible = false;
            Ride3.Visible = false;
            Ride4.Visible = false;
            Ride1.Location = new Point(3, 328);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ride1.Location = new Point(Ride1.Location.X + Speed, Ride1.Location.Y);

            if (Ride1.Location.X > 784)
            {
                Ride1.Visible = false;
                Ride2.Visible = true;
                timer2.Start();
                timer1.Stop();
                Ride1.Location = new Point(3, 328);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Ride2.Location = new Point(Ride2.Location.X, Ride2.Location.Y - Speed);

            if (Ride2.Location.Y < 2)
            {
                Ride2.Visible = false;
                Ride3.Visible = true;
                timer3.Start();
                timer2.Stop();
                Ride2.Location = new Point(784, 328);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Ride3.Location = new Point(Ride3.Location.X - Speed, Ride3.Location.Y);

            if (Ride3.Location.X < 4)
            {
                Ride3.Visible = false;
                Ride4.Visible = true;
                timer4.Start();
                timer3.Stop();
                Ride3.Location = new Point(784, 2);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Ride4.Location = new Point(Ride4.Location.X, Ride4.Location.Y + Speed);

            if (Ride4.Location.Y > 328)
            {
                Ride4.Visible = false;
                Ride1.Visible = true;
                timer1.Start();
                timer4.Stop();
                Ride4.Location = new Point(4, 2);
            }
        }
    }
}
