using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class callForm3 : Form
    {
        int appleCount, lemonCount, eggonCount, milkCount = 0;
        string appleMassage, lemonMassage, eggMassage, milkMassage = "";

        public callForm3()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            appleCount = 0; lemonCount = 0; eggonCount = 0; milkCount = 0;
            appleMassage = ""; lemonMassage = ""; eggMassage = ""; milkMassage = "";
            txtList.Text = "尚未點餐";
            txtPrice.Text = "NT$ 0 ";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額 : NT${CalculateTotalPrice()}", "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            string message = $"總金額 : {txtPrice.Text}\n折扣後金額 : NT${CalculateTotalPrice() * 0.9}";
            MessageBox.Show(message, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            Product apple;
            apple.Name = "蘋果";
            apple.Quantity = ++appleCount;
            apple.Price = 30 * appleCount;
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

        #region 私有方法

        /// <summary>
        /// 顯示購買清單
        /// </summary>
        /// <param name="pro">商品</param>
        private void ShowProductList(Product pro)
        {
            switch (pro.Name)
            {
                case "蘋果":
                    appleMassage = pro.Message + "\r\n";
                    break;
                case "檸檬":
                    lemonMassage = pro.Message + "\r\n";
                    break;
                case "雞蛋":
                    eggMassage = pro.Message + "\r\n";
                    break;
                case "牛奶":
                    milkMassage = pro.Message + "\r\n";
                    break;
            }

            txtList.Text = "";
            txtList.Text = appleMassage + lemonMassage + eggMassage + milkMassage;
            txtPrice.Text = "NT$" + CalculateTotalPrice();
        }

        /// <summary>
        /// 計算總金額
        /// </summary>
        /// <returns></returns>
        private int CalculateTotalPrice()
        {
            int result = (appleCount * 30) + (lemonCount * 20) + (eggonCount * 10) + (milkCount * 50);
            return result;
        }

        #endregion
    }
}
