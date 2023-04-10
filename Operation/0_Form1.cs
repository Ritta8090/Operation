using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Forms1(object sender, EventArgs e)
        {

        }

    

        private void callForm2(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void callForm3(object sender, EventArgs e)
        {
            callForm3 f3 = new callForm3();
            f3.Show();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            this.IsMdiContainer = true; //指定為父視窗


        }
        
    }
}
