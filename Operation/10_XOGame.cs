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
    public partial class callForm10 : Form
    {
        private Button[] xoArray = new Button[9];
        bool isGameOver = false;     //有連線成功則結束
        bool isO = false;     //點選是 O 還是 X

        static private int[,] win = new int[,] // int[8,3]
        {
            {0,1,2}, {3,4,5}, {6,7,8},
            {0,3,6}, {1,4,7}, {2,5,8},
            {0,4,8}, {2,4,6}
        };

        public callForm10()
        {
            InitializeComponent();
            xoArray = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }

        /// <summary>
        /// 設定一開始9個按鈕的預設值
        /// </summary>
        private void XOButtons()
        {
            isGameOver = false;
            isO = true;
            for (int i = 0; i < xoArray.Length; i++)
            {
                xoArray[i].Text = "";
                xoArray[i].Enabled = true;
            }
        }

        /// <summary>
        /// 9顆按鈕的點擊事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickHandler(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            tmpButton.Text = isO ? "O" : "X";
            tmpButton.Enabled = false;

            bool[] result = CheckWinGroup(xoArray);
            if (result[0] && result[1])
            {

            }
            else
            {
                isO = !isO;
            }
        }

        /// <summary>
        /// 判斷勝利
        /// </summary>
        /// <param name="myControls"></param>
        /// <returns></returns>
        private bool[] CheckWinGroup(Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                int a = win[i, 0];
                int b = win[i, 1];
                int c = win[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                //沒有連線就繼續
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                //連線成功，遊戲結束
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    MessageBox.Show($"{(isO ? "O" : "X")}選手獲勝", "完局", MessageBoxButtons.OKCancel);
                    gameWinOver = new bool[2] { true, true };
                    break;
                }

                //九格填完，顯示結束
                if (myControls[i].Text != "")
                {
                    btnIsUse++;
                    if (btnIsUse == 9)
                    {
                        gameWinOver[1] = true;
                        MessageBox.Show($"平手", "完局", MessageBoxButtons.OKCancel);
                    }
                }
            }

            return gameWinOver;
        }

        /// <summary>
        /// Reset(R) 重置/重來
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            XOButtons();
        }

        /// <summary>
        /// Exist(Esc) 關閉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

