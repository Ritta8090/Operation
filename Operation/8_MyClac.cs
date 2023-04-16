using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class callForm8 : Form
    {
        public callForm8()
        {
            InitializeComponent();
        }
        decimal num1, num2;
        public void Judgment()
        {
            
            bool isNum1 = decimal.TryParse(txtN1.Text, out num1);
            bool isNum2 = decimal.TryParse(txtN2.Text, out num2);

            if (isNum1 == false)
            {
                MessageBox.Show($"{txtN1.Text}非數字, 請入數字");
                txtN1.Clear();
                txtN2.Clear();
            }

            if (isNum2 == false)
            {
                MessageBox.Show($"{txtN2.Text}非數字, 請入數字");
                txtN1.Clear();
                txtN2.Clear();
            }

            //switch (data)
            //{
            //    case 1 : txtAnswer.Text = (num1 + num2).ToString(); break;
            //    case 2: txtAnswer.Text = (num1 - num2).ToString(); break;
            //    case 3: txtAnswer.Text = (num1 * num2).ToString(); break;
            //    case 4: txtAnswer.Text = (num1 / num2).ToString(); break;
            //    default: break;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Judgment();
            txtAnswer.Text = (num1 + num2).ToString();
        }        
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Judgment();
            txtAnswer.Text = (num1 - num2).ToString();
        }   
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Judgment();
            txtAnswer.Text = (num1 * num2).ToString();
        }
        private void btnDivided_Click(object sender, EventArgs e)
        {
            Judgment();
            txtAnswer.Text = (num1 / num2).ToString();
        }
    }
}
