using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeroMayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(txtN1.Text);
            int n2 = Int32.Parse(txtN2.Text);
            int n3 = Int32.Parse(txtN3.Text);
            if(n1>n2 && n1 > n3)
            {
                MessageBox.Show("El numero mayor es: "+n1);
            }else if(n2 > n1 && n2 > n3)
            {
                MessageBox.Show("El numero mayor es: " + n2);
            }
            else
            {
                MessageBox.Show("El numero mayor es: " + n3);
            }


        }
    }
}
