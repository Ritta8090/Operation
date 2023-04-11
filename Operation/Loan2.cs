using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Operation
{
    public partial class Loan2 : Form
    {
        public Loan2()
        {
            InitializeComponent();
        }

        public Loan2(string strForm1TextBox1, string strForm1TextBox2, 
            string strForm1TextBox3, string strForm1TextBox4, string strForm1TextBox5)
        {
            InitializeComponent();

            label6.Text = strForm1TextBox1;
            label7.Text = strForm1TextBox2;
            label8.Text = strForm1TextBox3;
            label9.Text = strForm1TextBox4;
            label10.Text = strForm1TextBox5;
        }

    }
}
