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
        int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string showArray = "";

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            bool number = int.TryParse(txtnumber.Text, out i);

            if (number == true)
            {
                labresult.Text = i % 2 == 0 ? $"輸入的數{txtnumber.Text}為偶數" : $"輸入的數{txtnumber.Text}為奇數";
                //if (i % 2 ==0)
                //    labresult.Text = $"輸入的數{txtnumber.Text}為奇數";
                //else
                //    labresult.Text = $"輸入的數{txtnumber.Text}為偶數";
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string showArray = "";
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
                //if (i == number.Length - 1)
                //    showArray += number[i];
                //else 
                //    showArray += number[i] + " , ";                          
            }
            labresult.Text = $"int陣列arr0711 [ {showArray} ] \r\n最大值為{number.Max()}\r\n最小值為{number.Min()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string showArray = "";
            int odd = 0, even = 0;
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";

                if (number[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            labresult.Text = $"int陣列arr0711 [ {showArray} ] \r\n奇數共 {odd}\r\n偶數共 {even}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] myString = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string showArray = "";
            string maxLength = "";
            foreach (var str in myString)
            {
                if (str.Length > maxLength.Length)
                {
                    maxLength = str;
                }
                showArray += str + ", ";
            }
            showArray = showArray.TrimEnd(' ').TrimEnd(',');
            labresult.Text = $"陣列arr0711_Str [ {showArray} ] \r\n最長的名字為 {maxLength}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] myString = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string showArray = "";
            int C_count = 0;
            foreach (var str in myString)
            {
                foreach (var item in str)
                {
                    if (item == 'C' || item == 'c')
                    {
                        C_count++;
                        break;
                    }
                }
                showArray += str + ", ";
            }
            showArray = showArray.TrimEnd(' ').TrimEnd(',');
            labresult.Text = $"arr0711_Str陣列 [ {showArray} ] \r\n有C 及 c的名字共有 {C_count} 個";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labresult.Text = "結果";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
            }
            int sum = 0;
            //foreach (var item in number)
            //{
            //    sum += item;
            //}
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            labresult.Text = $"int陣列arr0711 [ {showArray} ] \r\n加總為 {sum}";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string showArray = "";
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
            }
            labresult.Text = $"int陣列arr0711 [ {showArray} ] \r\n最大值為 {number.Max()}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string showArray = "";
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
            }
            labresult.Text = $"int陣列arr0711[ {showArray} ]\r\n最小值為 {number.Min()}";
        }
    }

}
