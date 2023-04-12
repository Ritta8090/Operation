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
        void ShowProductList()
        {
            //decimal totalPrice = 0;
            //txtList.Text = "\n";
            
            foreach (Product pro in IsPro)
            {
                txtList.Text = $"{pro.Name}" +$"X{pro.Quantity}"+
                    $",共計{pro.Price}"+"元\r\n";
                //totalPrice += (pro).Price;
            }

       
        }
        List<Product> IsPro = new List<Product>();


        int i = 1;
        private void btnApple_Click(object sender, EventArgs e)
        {
            Product Pro;
            Pro.Name = "蘋果";
            Pro.Price = 30*i;
            Pro.Quantity = i++;

            IsPro.Add(Pro);

            ShowProductList();


        }

        private void btnLemon_Click(object sender, EventArgs e)
        {
            Product Pro;
            Pro.Name = "檸檬";
            Pro.Price = 20 * i;
            Pro.Quantity = i++;

            IsPro.Add(Pro);

            ShowProductList();
        }

        
    }

}
