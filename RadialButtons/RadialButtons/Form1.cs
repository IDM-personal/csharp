using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadialButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bttns = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            if(bttns != null && nbr1.Text.Length != 0 && nbr2.Text.Length != 0)
            {
                switch(bttns.Name)
                {
                    case "mas":
                        Result.Text = (Int16.Parse(nbr1.Text) + Int16.Parse(nbr2.Text)).ToString();
                        break;
                    case "menos":
                        Result.Text = (Int16.Parse(nbr1.Text) - Int16.Parse(nbr2.Text)).ToString();
                        break;
                    case "mult":
                        Result.Text = (Int16.Parse(nbr1.Text) * Int16.Parse(nbr2.Text)).ToString();
                        break;
                    case "div":
                        Result.Text = (Int16.Parse(nbr1.Text) / Int16.Parse(nbr2.Text)).ToString();
                        break;
                }
            }
        }
    }
}
