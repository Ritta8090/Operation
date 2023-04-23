using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        //int i;
        int[] number = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string showArray = "";
        string[] myString = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };


        #region 已完成

        private void button1_Click(object sender, EventArgs e)
        {
            bool number = int.TryParse(txtnumber.Text, out int i);

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
        private void btnlongest_Click(object sender, EventArgs e)
        {
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
        private void btnC_Click(object sender, EventArgs e)
        {
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
        private void btnclear_Click(object sender, EventArgs e)
        {
            labresult.Text = "結果";
        }

        #endregion

        private void btnArray10_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string showItem = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 && j != 9)
                    {
                        showItem += " 1 ";
                    }
                    if (i == 0 && j == 9)
                    {
                        showItem += " 1 \r\n 1 ";
                    }
                    if (i > 0 && i < 9 && j > 0 && j < 9)
                    {
                        showItem += " 0 ";
                    }
                    if (i > 0 && i < 9 && j == 9)
                    {
                        showItem += " 1 \r\n 1 ";
                    }
                    if (i == 9 && j < 9)
                    {
                        showItem += " 1 ";
                    }
                }
                labresult.Text = showItem;
            }
        }
        private void btnArray01_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string showItem = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    switch (i)
                    {
                        case 0:
                        case 9: showItem += j == 9 ? " 0 \r\n" : " 0 "; break;
                        default:
                            switch (j)
                            {
                                case 0:
                                case 9: showItem += j == 0 ? " 0 " : " 0 \r\n"; break;
                                default:
                                    showItem += " 1 "; break;
                            }
                            break;
                    }
                }
            }
            labresult.Text = showItem;
        }
        private void btnArray1010_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string showItem = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    showItem += (i + j) % 2 == 0 ? " 1 " : " 0 ";
                    if (j == 9)
                    {
                        showItem += "\r\n";
                    }
                }
            }
            labresult.Text = showItem;
        }
        private void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        private void btnswap_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 200;
            labresult.Text = $"換位前na={a} , n2 = {b}\r\n";
            swap(ref a, ref b);
            labresult.Text += $"換位後na={a} , n2 = {b}";

        }
        private void btnsum_Click(object sender, EventArgs e)
        {
            string showArray = "";
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
        private void btnmax_Click(object sender, EventArgs e)
        {
            string showArray = "";
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
            }
            labresult.Text = $"int陣列arr0711 [ {showArray} ] \r\n最大值為 {number.Max()}";
        }
        private void btnmin_Click(object sender, EventArgs e)
        {
            string showArray = "";
            for (int i = 0; i < number.Length; i++)
            {
                showArray += (i == number.Length - 1) ? number[i].ToString() : number[i] + ",";
            }
            labresult.Text = $"int陣列arr0711[ {showArray} ]\r\n最小值為 {number.Min()}";
        }
        private InputPara FWD()
        {
            InputPara result = new InputPara();

            bool numberfrom = int.TryParse(txtfrom.Text, out int from);
            bool numberto = int.TryParse(txtto.Text, out int to);
            bool numberstep = int.TryParse(txtstep.Text, out int step);

            if (!numberfrom || !numberto || !numberstep)
            {
                MessageBox.Show("請輸入整數");
            }
            else
            {
                result.From = from;
                result.To = to;
                result.Step = step;
            }
            return result;
        }
        public class InputPara
        {
            public int From;
            public int To;
            public int Step;
        }
        private void btnfor_Click(object sender, EventArgs e)
        {
            InputPara data = FWD();
            int total = 0;
            for (int i = data.From; i <= data.To; i += data.Step)
            {
                total += i;
            }
            labresult.Text = $"{data.From} 到 {data.To} 相隔 {data.Step - 1} \r\n加總為 {total}";
        }
        private void btnwhile_Click(object sender, EventArgs e)
        {
            InputPara data = FWD();
            int start = data.From;
            int total = 0;
            while (data.From <= data.To)
            {
                total += data.From;
                data.From += data.Step;
            }
            labresult.Text = $"{start} 到 {data.To} 相隔 {data.Step - 1} \r\n加總為 {total}";

        }
        private void btndo_Click(object sender, EventArgs e)
        {
            InputPara data = FWD();
            int start = data.From;
            int total = 0;
            do
            {
                total += data.From;
                data.From += data.Step;
            }
            while (data.From <= data.To);

            labresult.Text = $"{start} 到 {data.To} 相隔 {data.Step - 1} \r\n加總為 {total}";
        }
        private void btn99_Click(object sender, EventArgs e)
        {
            string showArray = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    showArray += $"{j}X{i}={i * j}| ";
                }
                showArray += "\r\n";
                labresult.Text = "九九乘法表\r\n" + showArray;
            }
        }
        private void btn_tree_Click(object sender, EventArgs e)
        {
            string showArray = "";
            bool number = int.TryParse(txtrows.Text, out int i);
            if (number == true)
            {
                int num = Convert.ToInt32(txtrows.Text);
                for (int j = 1; j <= num; j++)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        showArray += "*";
                    }
                    showArray += "\r\n";
                }
                labresult.Text = showArray;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
        private void btnbinary_Click(object sender, EventArgs e)
        {
            int Number = 100;
            int binaryNumber;
            string binary = "";

            while (Number > 0)
            {
                binaryNumber = Number % 2;
                Number /= 2;
                binary = binaryNumber.ToString() + binary;
            }
            //string binary = Convert.ToString(Number, 2);
            labresult.Text =  binary;
        }
        private void btnlotto_Click(object sender, EventArgs e)
        {
            string showItem = "";
            int[] lottoArray = new int[6];
            Random rnd = new Random();
            for (int i = 0; i <= 5; i++)
            {
                lottoArray[i] = rnd.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    while (lottoArray[j] == lottoArray[i])
                    {
                        j = 0;
                        lottoArray[i] = rnd.Next(1, 50);
                    }
                }
            }
            //showItem =$" {lottoArray[0]} {lottoArray[1]} {lottoArray[2]} {lottoArray[3]} {lottoArray[4]} {lottoArray[5]}";
            showItem = string.Join(", ", lottoArray);
            labresult.Text = "樂透號碼\r\n" + showItem;
        }

     
    }

}
