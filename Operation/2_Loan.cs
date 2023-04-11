using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Operation
{
    public partial class callForm3 : Form
    {
        public callForm3()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int tatle = int.Parse(textBox1.Text);  //貸款金額
            int month = int.Parse(textBox2.Text)*12;  //期限(年->月)
            double rate = double.Parse(textBox3.Text)/100/12;  //利率(%)
            int payment = int.Parse(textBox4.Text);  //頭期款

            string resoult = "";
            double calculate = (Math.Pow((1 + rate), month) * rate)/ (Math.Pow((1 + rate), month) - 1);
            int calculate2 = (int)Math.Round((tatle * calculate));
            resoult = Convert.ToString(calculate2);
            MessageBox.Show("月付額: "+resoult + "元");

            //每月應付本息金額之平均攤還率＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率＝每月應還本金金額＋每月應付利息金額
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tatle = int.Parse(textBox1.Text);  //貸款金額
            int month = int.Parse(textBox2.Text) * 12;  //期限(年->月)
            double rate = double.Parse(textBox3.Text) / 100 / 12;  //利率(%)
            int payment = int.Parse(textBox4.Text);  //頭期款

            string resoult2 = "";
            double calculate = (Math.Pow((1 + rate), month) * rate) / (Math.Pow((1 + rate), month) - 1);
            int calculate2 = (int)Math.Round((tatle * calculate));
            resoult2 = Convert.ToString(calculate2* month);
            MessageBox.Show("總付款: " + resoult2 + "元");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tatle = int.Parse(textBox1.Text);  //貸款金額
            int month = int.Parse(textBox2.Text) * 12;  //期限(年->月)
            double rate = double.Parse(textBox3.Text) / 100 / 12;  //利率(%)
            int payment = int.Parse(textBox4.Text);  //頭期款

            string resoult = "";
            double calculate = (Math.Pow((1 + rate), month) * rate) / (Math.Pow((1 + rate), month) - 1);
            int calculate2 = (int)Math.Round((tatle * calculate));
            resoult = Convert.ToString(calculate2);
            string resoult2 = "";
            resoult2 = Convert.ToString(calculate2 * month);


            Loan2 L2 = new Loan2(textBox1.Text, textBox2.Text, textBox3.Text, resoult, resoult2);
            L2.Show();
            
        }

        
    }


   
    
}
