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
        void ShowProductList(Product pro)
        {
            if ()
            
            
            
            
            txtList.Text = "";
            txtList.Text += pro.Message + "\n";
            
           


        }
       

        int appleCount,lemonCount = 0;

        private void btnApple_Click(object sender, EventArgs e)
        {
            //int appleCount = 0;
            Product apple;                 //宣告
            apple.Name = "蘋果";
            apple.Quantity = ++appleCount;
            apple.Price = 30* appleCount;
            apple.Message = $"蘋果 X {apple.Quantity} ,共計 {apple.Price} 元";


            //IsPro.Add(apple);

            ShowProductList(apple);


        }

        private void btnLemon_Click(object sender, EventArgs e)
        {
            //int lemonCount = 0;
            Product lemon;
            lemon.Name = "檸檬";
            lemon.Quantity = ++lemonCount;
            lemon.Price = 20 * lemonCount;
            lemon.Message = $"檸檬 X {lemon.Quantity},共計{lemon.Price} 元";

            //IsPro.Add(lemon);

            ShowProductList(lemon);
        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
