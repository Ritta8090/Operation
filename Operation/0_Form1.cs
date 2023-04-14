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

        private void callForm4(object sender, EventArgs e)
        {
            callForm4 f4 = new callForm4();
            f4.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f4);
            f4.Show();
        }

        private void callForm5(object sender, EventArgs e)
        {
            callForm5 f5 = new callForm5();
            f5.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f5);
            f5.Show();
        }

        private void callForm6(object sender, EventArgs e)
        {
            callForm6 f6 = new callForm6();
            f6.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f6);
            f6.Show();
        }

        private void callForm7(object sender, EventArgs e)
        {
            callForm7 f7 = new callForm7();
            f7.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f7);
            f7.Show();
        }
        
        private void callForm8(object sender, EventArgs e)
        {
            callForm8 f8 = new callForm8();
            f8.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f8);
            f8.Show();
        }

        private void callForm9(object sender, EventArgs e)
        {
            callForm9 f9 = new callForm9();
            f9.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f9);
            f9.Show();
        }

        private void callForm10(object sender, EventArgs e)
        {
            callForm10 f10 = new callForm10();
            f10.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(f10);
            f10.Show();
        }
    }
}
