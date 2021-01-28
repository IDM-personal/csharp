using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Error","Saludo",MessageBoxButtons.YesNo,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
            Console.WriteLine(dr.ToString());
        }
    }
}
