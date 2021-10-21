using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double n3 = Convert.ToDouble(txt3.Text);
            
            double result = (n1 + n2 + n3) / 3;
            MessageBox.Show("resultado"+result);
        }
    }
}
