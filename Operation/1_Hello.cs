using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            string Name2 = txtname2.Text;
            string Gender = txtgender.Text;
            string Star = txtstar.Text;
            MessageBox.Show("Hello,我是" + Name + ", " + "\r\n" +
                            "英文名字是" + Name2 + ", " + "\r\n" +
                            "性別是" + Gender + ", " + "\r\n" +
                            "星座是" + Star + ", " + "\r\n" +
                            "很高興認識你");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            string Name2 = txtname2.Text;
            string Gender = txtgender.Text;
            string Star = txtstar.Text;
            MessageBox.Show("Hi,我是" + Name + "," + "\r\n" +
                            "英文名字是" + Name2 + ", " + "\r\n" +
                            "性別是" + Gender + ", " + "\r\n" +
                            "星座是" + Star + ", " + "\r\n" +
                            "很高興認識你");
        }
    }
}
