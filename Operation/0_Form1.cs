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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Forms1(object sender, EventArgs e)
        {

        }
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            this.IsMdiContainer = true; //指定為父視窗


        }


        private void callForm1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f1);
            f1.Show();

        }

        private void callForm2(object sender, EventArgs e)
        {
            callForm2 f2 = new callForm2();
            f2.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f2);
            f2.Show();
        }

        private void callForm3(object sender, EventArgs e)
        {
            callForm3 f3 = new callForm3();
            f3.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f3);
            f3.Show();
        }
    }
}
