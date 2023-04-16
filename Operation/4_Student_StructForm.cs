using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class callForm4 : Form
    {
        string name, high, low;
        int chinese, english, math;



        public callForm4()
        {
            InitializeComponent();
        }


        private void btnStore_Click(object sender, EventArgs e)
        {

            name = txtName.Text;
            chinese = Convert.ToInt32(txtChinese.Text);
            english = Convert.ToInt32(txtEnglish.Text);
            math = Convert.ToInt32(txtMath.Text);

            string save = $"姓名 : {name}\r\n國文 : {chinese}分\r\n英文 : {english}分\r\n數學 : {math}分";

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            txt_AllScore.Text = $"姓名 : {name}\r\n國文 : {chinese}分\r\n英文 : {english}分\r\n數學 : {math}分";
        }
        private void btnScore_Click(object sender, EventArgs e)
        {
            if (chinese > english)
            {
                if (chinese > math)
                {
                    if (math > english)
                    {
                        high = "國文" + chinese;
                        low = "英文" + english;
                    }
                    else
                    {
                        high = "國文" + chinese;
                        low = "數學" + math;
                    }
                }
                else
                {
                    high = "數學" + math;
                    low = "英文" + english;
                }
            }
            if (chinese < english)
            {
                if (math < english)
                {
                    if (math > chinese)
                    {
                        high = "英文" + english;
                        low = "國文" + chinese;
                    }
                    else
                    {
                        high = "英文" + english;
                        low = "數學" + math;
                    }
                }
                else
                {
                    high = "數學" + math;
                    low = "國文" + chinese;
                }
            }

            txtHigh_Low.Text = $"最高科目成績為 : {high}分\r\n最低科目成績為 : {low}分";
        }
   
    }
}
