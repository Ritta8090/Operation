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
    public partial class _15_guess : Form
    {
        public _15_guess()
        {
            InitializeComponent();
            
        }
        int guess;
        private void btnguess_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            guess = rnd.Next(1, 100);
            Guess g2 = new Guess(guess);
            g2.Owner = this;
            g2.Show();
        }

        private void btnanswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : " +guess);
        }
    }
}
