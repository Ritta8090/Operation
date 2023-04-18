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
    public partial class callForm9 : Form
    {
        public callForm9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i;
            bool number = int.TryParse(txtnumber.Text, out i);

            if (number == true)
            {
                if (i % 2 > 0)
                {
                    labresult.Text = $"輸入的數{txtnumber.Text}為奇數";
                }
                else
                {
                    labresult.Text = $"輸入的數{txtnumber.Text}為偶數";
                }
            }

            else 
            {
                MessageBox.Show("請輸入整數");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 878 };

            string showArray="";
            for (int i = 0; i < number.Length; i++)
            {

                showArray += (i == number.Length - 1) ? showArray += number[i]: showArray += number[i] + " , ";
                //if (i == number.Length - 1)
                //{
                //    showArray += number[i];
                //}
                //else 
                //{
                //    showArray += number[i] + " , ";
                //}
                
                
            }
            labresult.Text =$"int陣列arr0711 [ {showArray} ] \r\n最大值為{number.Max()}\r\n最小值為{number.Min()}";
        }
    }
}
