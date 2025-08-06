using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegarek_Binarny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sekund = Int32.Parse(label8.Text) + 1;

            label8.Text = sekund.ToString();

            int minut = Int32.Parse(label7.Text);

            label7.Text = minut.ToString();

            int godz = Int32.Parse(label6.Text);

            label6.Text = godz.ToString();

            DateTime now = DateTime.Now;
            label6.Text = now.Hour.ToString("D2");
            label7.Text = now.Minute.ToString("D2");
            label8.Text = now.Second.ToString("D2");

            label1.Text = label6.Text + ":" + label7.Text + ":" + label8.Text;

            switch (sekund)
            {

                case int n when n <= 0 && n < 1:
                    panel16.BackColor = Color.SkyBlue;
                    panel15.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.SkyBlue;
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 1 && n < 2:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 2 && n < 3:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 3 && n < 4:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 4 && n < 5:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 5 && n < 6:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 6 && n < 7:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 7 && n < 8:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 8 && n < 9:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 9 && n < 10:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 10 && n < 11:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel16.BackColor = Color.Red;
                    break;
                case int n when n <= 11 && n < 12:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    panel14.BackColor = Color.SkyBlue;
                    panel15.BackColor = Color.SkyBlue;
                    panel16.BackColor = Color.Red;
                    break;
                case int n when n <= 12 && n < 13:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 13 && n < 14:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 14 && n < 15:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 15 && n < 16:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 16 && n < 17:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 17 && n < 18:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 18 && n < 19:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 19 && n < 20:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 20 && n < 21:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel15.BackColor = Color.Red;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 21 && n < 22:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    panel14.BackColor = Color.SkyBlue;
                    panel15.BackColor = Color.Red;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 22 && n < 23:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 23 && n < 24:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 24 && n < 25:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 25 && n < 26:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 26 && n < 27:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 27 && n < 28:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 28 && n < 29:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 29 && n < 30:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 30 && n < 31:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.SkyBlue;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 31 && n < 32:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.SkyBlue;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 32 && n < 33:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 33 && n < 34:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 34 && n < 35:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 35 && n < 36:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 36 && n < 37:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 37 && n < 38:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 38 && n < 39:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 39 && n < 40:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 40 && n < 41:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.SkyBlue;
                    panel16.BackColor = Color.Red;
                    break;
                case int n when n <= 41 && n < 42:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 42 && n < 43:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 43 && n < 44:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 44 && n < 45:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 45 && n < 46:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 46 && n < 47:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 47 && n < 48:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 48 && n < 49:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 49 && n < 50:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 50 && n < 51:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.Red;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 50 && n < 51:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.Red;
                    panel15.BackColor = Color.Red;
                    panel16.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 51 && n < 52:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 52 && n < 53:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 53 && n < 54:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 54 && n < 55:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 55 && n < 56:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 56 && n < 57:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 57 && n < 58:
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.Red;
                    panel17.BackColor = Color.Red;
                    panel18.BackColor = Color.Red;
                    break;
                case int n when n <= 58 && n < 59:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 59 && n < 60:
                    panel20.BackColor = Color.Red;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.Red;
                    break;



                default:

                    panel16.BackColor = Color.SkyBlue; 
                    panel15.BackColor = Color.SkyBlue;
                    panel14.BackColor = Color.SkyBlue;
                    panel20.BackColor = Color.SkyBlue;
                    panel19.BackColor = Color.SkyBlue;
                    panel17.BackColor = Color.SkyBlue;
                    panel18.BackColor = Color.SkyBlue;
                    break;

                    


            }
            switch (minut)
            {
                case int n when n <= 0 && n < 1:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    break;

                case int n when n <= 1 && n < 2:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    break;
                case int n when n <= 2 && n < 3:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 3 && n < 4:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    break;
                case int n when n <= 4 && n < 5:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 5 && n < 6:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    break;
                case int n when n <= 6 && n < 7:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 7 && n < 8:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    break;
                case int n when n <= 8 && n < 9:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 9 && n < 10:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    break;
                case int n when n <= 10 && n < 11:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 11 && n < 12:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 12 && n < 13:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 13 && n < 14:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 14 && n < 15:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 16 && n < 17:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 17 && n < 18:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 18 && n < 19:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 19 && n < 20:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 20 && n < 21:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 21 && n < 22:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 21 && n < 22:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 22 && n < 23:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 23 && n < 24:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 24 && n < 25:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 25 && n < 26:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 26 && n < 27:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 28 && n < 29:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 29 && n < 30:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 30 && n < 31:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 30 && n < 31:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 31 && n < 32:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 32 && n < 33:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 33 && n < 34:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 34 && n < 35:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 35 && n < 36:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 36 && n < 37:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 37 && n < 38:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 38 && n < 39:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 39 && n < 40:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    break;
                case int n when n <= 40 && n < 41:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 41 && n < 42:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;       
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 42 && n < 43:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 43 && n < 44:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 44 && n < 45:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 46 && n < 47:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 47 && n < 48:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 48 && n < 49:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 49 && n < 50:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    break;
                case int n when n <= 50 && n < 51:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 51 && n < 52:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 52 && n < 53:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 53 && n < 54:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 54 && n < 55:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 56 && n < 57:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 57 && n < 58:
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.Red;
                    panel12.BackColor = Color.Red;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 58 && n < 59:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                case int n when n <= 59 && n < 60:
                    panel10.BackColor = Color.Red;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.Red;
                    panel9.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    break;
                
                default:
                    panel1.BackColor = Color.SkyBlue;
                    panel9.BackColor = Color.SkyBlue;
                    panel2.BackColor = Color.SkyBlue;
                    panel10.BackColor = Color.SkyBlue;
                    panel11.BackColor = Color.SkyBlue;
                    panel12.BackColor = Color.SkyBlue;
                    panel13.BackColor = Color.SkyBlue;
                    break;

            }

            switch (godz)
            {
                case int n when n <= 0 && n < 1:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue; 
                    break;
                case int n when n <= 1 && n < 2:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    break;
                case int n when n <=2 && n < 3:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 3 && n < 4:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    break;
                case int n when n <= 4 && n < 5:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 5 && n < 6:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    break;
                case int n when n <= 6 && n < 7:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 7 && n < 8:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    break;
                case int n when n <= 8 && n < 9:
                    panel8.BackColor = Color.Red;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    break;
                case int n when n <= 9 && n < 10:
                    panel8.BackColor = Color.Red;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    break;
                case int n when n <= 10 && n < 11:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 11 && n < 12:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 12 && n < 13:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 13 && n < 14:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 14 && n < 15:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 15 && n < 16:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 16 && n < 17:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 17 && n < 18:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 18 && n < 19:
                    panel8.BackColor = Color.Red;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 19 && n < 20:
                    panel8.BackColor = Color.Red;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 20 && n < 21:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 21 && n < 22:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.Red;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 22 && n < 23:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.SkyBlue;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 23 && n < 24:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;
                case int n when n <= 24 && n < 25:
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.Red;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    break;


                default:
                    panel3.BackColor = Color.SkyBlue;
                    panel4.BackColor = Color.SkyBlue;
                    panel8.BackColor = Color.SkyBlue;
                    panel7.BackColor = Color.SkyBlue;
                    panel6.BackColor = Color.SkyBlue;
                    panel5.BackColor = Color.SkyBlue;
                    break;
            }



        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
