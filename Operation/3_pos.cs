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
    public partial class callForm3 : Form
    {
        public callForm3()
        {
            InitializeComponent();
        }
        //txtPrice
        //txtList
                
        private void btnApple_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 1 ;
            i++;
            int price = 30;
            result = "蘋果 X " + i + ",共計$" + price*i + "元";
            txtList.Text = result;

        }
    }
}
