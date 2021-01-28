using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealCalc
{
    public partial class Form1 : Form
    {
        String nbr = "0";
        String herenbrprev = "";
        int lastaction = -1;
        int resetnbr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void nbr0_Click(object sender, EventArgs e)
        {
            if (!nbr.Equals("0"))
                nbr = String.Concat(nbr, "0");
            current.Text = nbr;
        }

        private void nbr1_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "1";
            else
                nbr = String.Concat(nbr, "1");
            current.Text = nbr;
        }

        private void nbr2_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "2";
            else
                nbr = String.Concat(nbr, "2");
            current.Text = nbr;
        }

        private void nbr3_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "3";
            else
                nbr = String.Concat(nbr, "3");
            current.Text = nbr;
        }

        private void nbr4_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "4";
            else
                nbr = String.Concat(nbr, "4");
            current.Text = nbr;
        }

        private void nbr5_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "5";
            else
                nbr = String.Concat(nbr, "5");
            current.Text = nbr;
        }

        private void nbr6_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "6";
            else
                nbr = String.Concat(nbr, "6");
            current.Text = nbr;
        }

        private void nbr7_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "7";
            else
                nbr = String.Concat(nbr, "7");
            current.Text = nbr;
        }

        private void nbr8_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "8";
            else
                nbr = String.Concat(nbr, "8");
            current.Text = nbr;
        }

        private void nbr9_Click(object sender, EventArgs e)
        {
            if (nbr.Equals("0"))
                nbr = "9";
            else
                nbr = String.Concat(nbr, "9");
            current.Text = nbr;
        }

        private void mas_Click(object sender, EventArgs e)
        {
            if(herenbrprev.Length != 0)
            {
                herenbrprev = (Int16.Parse(herenbrprev) + Int16.Parse(current.Text)).ToString();
                current.Text = herenbrprev;
                nbr = "0";
            }
            else
            {
                herenbrprev = current.Text;
                nbr = "0";
            }
            lastaction = 0;
        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void mult_Click(object sender, EventArgs e)
        {

        }

        private void div_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            /*
             * lastaction = 0 -> suma
             * lastaction = 1 -> resta
             * lastaction = 2 -> mult
             * lastaction = 3 -> div
             */
            if (herenbrprev.Length != 0 && nbr != "0" && lastaction != -1)
            {
                switch(lastaction)
                {
                    case 0:
                        herenbrprev = (Int16.Parse(herenbrprev) + Int16.Parse(current.Text)).ToString();
                        current.Text = herenbrprev;
                        break ; 
                }
            }
        }

        private void sqr_Click(object sender, EventArgs e)
        {

        }

        private void root_Click(object sender, EventArgs e)
        {

        }

        private void del1_Click(object sender, EventArgs e)
        {
            if (nbr.Length > 0)
                nbr = nbr.Remove(nbr.Length - 1);
            current.Text = nbr;
        }

        private void delall_Click(object sender, EventArgs e)
        {
            nbr = "";
            current.Text = nbr;
        }

        private void comma_Click(object sender, EventArgs e)
        {

        }

        private void negate_Click(object sender, EventArgs e)
        {

        }
    }
}
