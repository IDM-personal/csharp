using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enero28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Clicka(object sender, EventArgs e)
        {
            int calc = 0;
            Console.WriteLine(Box1.Text.Substring(Box1.Text.IndexOf(" ")));
            if (Box1.Checked)
                calc += 500;
            if (Box2.Checked)
                calc += 35;
            if (Box3.Checked)
                calc += 15;
            MessageBox.Show("Precio total " + calc.ToString() + "€");
        }
    }
}
