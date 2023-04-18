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
    public partial class callForm5 : Form
    {
        
        public callForm5()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            //name = txtName.Text;
            //chinese = Convert.ToInt32(txtChinese.Text);
            //english = Convert.ToInt32(txtEnglish.Text);
            //math = Convert.ToInt32(txtMath.Text);
            //totalScore = chinese + english + math;
            //average = totalScore / 3;


            //DataGridView datagridview = new DataGridView();
            //DataGridViewTextBoxColumn dataGridView1 = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn dataGridViewCol2 = new DataGridViewTextBoxColumn();
            //dataGridView1.name = txtName.Text;
            //dataGridViewCol1.HeaderText = "Name";
            //dataGridViewCol2.Name = "dataGridViewCol2";
            //dataGridViewCol2.HeaderText = "Count";
        }

        public void plan()
        { 
            List<strings> Str = new List<strings>();
            Str.Add(new strings() {name = txtName.Text, });
        
        }

        public class strings
        {
            public string name, low, high;
            public int chinese, english, math, totalScore, average;

        }

    }
}
