using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtNumber.Text);
            if (number%2==0)
            {
                MessageBox.Show(number + " is pair");
            }
            else
            {
                MessageBox.Show(number + " is not pair");
            }
        }
    }
}
