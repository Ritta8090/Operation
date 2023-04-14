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
    public partial class callForm8 : Form
    {
        int Num1 , Num2 ;
        public callForm8()
        {
            InitializeComponent();
        }

        public void judge()
        {
            string Num1 = txtN1.Text;
            string Num2 = txtN2.Text;
            int n;
            bool Num = int.TryParse("", out n);

            MessageBox.Show("請輸入數字");
            txtN1.Clear();
            txtN2.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Num1 = txtN1.Text;
            string Num2 = txtN2.Text;
            int n;
            bool Num = int.TryParse(Num1, out n);

            MessageBox.Show("請輸入數字");
            txtN1.Clear();

            


            txtAnswer.Text = Num1 + Num2;

           




        }
        }
}
