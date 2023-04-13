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
            
            string apple = "";
            string lemon = "";
            string agg = "";
            string milk = "";
            
           

            switch (pro.Name)
            {
                case "蘋果":
                    apple += pro.Message + "\r\n";
                    break;

                case "檸檬":
                    lemon += pro.Message + "\r\n";
                    break;
                case "雞蛋":
                    agg += pro.Message + "\r\n";
                    break;
                case "牛奶":
                    milk += pro.Message + "\r\n";
                    break;

            }

            txtList.Text = apple + "\r\n"+ lemon+"\r\n";

        }
       

        int appleCount,lemonCount, eggonCount, milkCount = 0;

        private void btnApple_Click(object sender, EventArgs e)
        {
           
            Product apple;                 
            apple.Name = "蘋果";
            apple.Quantity = ++appleCount;
            apple.Price = 30* appleCount;
            apple.Message = $"蘋果 X {apple.Quantity} ,共計 {apple.Price} 元";
            ShowProductList(apple);


        }

        private void btnLemon_Click(object sender, EventArgs e)
        {
           
            Product lemon;
            lemon.Name = "檸檬";
            lemon.Quantity = ++lemonCount;
            lemon.Price = 20 * lemonCount;
            lemon.Message = $"檸檬 X {lemon.Quantity},共計{lemon.Price} 元";
            ShowProductList(lemon);
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            Product agg;
            agg.Name = "雞蛋";
            agg.Quantity = ++eggonCount;
            agg.Price = 10 * eggonCount;
            agg.Message = $"雞蛋X {agg.Quantity},共計{agg.Price} 元";
            ShowProductList(agg);
        }

        private void btnmilk_Click(object sender, EventArgs e)
        {
            Product milk;
            milk.Name = "牛奶";
            milk.Quantity = ++milkCount;
            milk.Price = 50 * milkCount;
            milk.Message = $"牛奶 X {milk.Quantity},共計{milk.Price} 元";
            ShowProductList(milk);
        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
