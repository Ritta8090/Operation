using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Operation.callForm9;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace Operation
{
    public partial class Guess : Form
    {
        int num, min = 1, max = 99;
        int guess;
        public Guess(int form15guess)
        {
            InitializeComponent();
            guess = form15guess;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool number = int.TryParse(textBox1.Text, out num);

            Label form15Label1 = (Label)this.Owner.Controls.Find("label1", true)[0];  //抓 主表單物件
            form15Label1.Text = "";                                                   // 給值

            if (number == true)
            {
                if ((num > max) || (num < min))
                {
                    MessageBox.Show($"請輸入{min}~{max}之間的數字");
                }
                else
                {
                    if (guess > num)
                    {
                        min = num;
                        form15Label1.Text = $"Too Small !!! Between {num} ~ {max}";
                    }
                    else if (guess < num)
                    {
                        max = num;
                        form15Label1.Text = $"Too Large !!! Between {min} ~{num}";
                    }
                    else if (guess == num)
                    {
                        MessageBox.Show($"Congradulations!!,You got {guess}!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入0~100之間的數字");
            }
        }
    }
}
