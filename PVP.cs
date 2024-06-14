using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class PVP : Form
    {
        private const int single_width = 50;
        private const int size = 13;
        private const int width = single_width*size;
        private int[,] chessBoard = new int[size + 1, size + 1];
        private int r = 20;
        Point original_point = new Point(0, 0);
        //private enum ChessColor
        //{
        //    White,
        //    Black
        //}
        private int round;
        //游戏是否开始的判断子start
        private bool start;
        //游戏胜负的判断子judge
        private int judge = 0;

        //Point 为什么不能为常量？

        public PVP()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StartGame(object sender, EventArgs e)
        {
            label1.Text = "游戏进行中";
            start = true;
            round = 0;
            richTextBox1.Text += $"第 {round / 2 + 1} 回合\n";
            richTextBox1.Text += "请落白子\n";
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret(); //Now scroll it automatically
            var g = pictureBox1.CreateGraphics();
            g.Clear(Color.Khaki);
            Pen pen = new Pen(Color.Black, 5);
            for (int i = 0; i < size + 1; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    chessBoard[i, j] = 0;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    g.DrawRectangle(pen, original_point.X + i * single_width, original_point.Y + j * single_width, single_width, single_width);
                }
            }
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //如果游戏进行中，则可以落子
            if (start)
            {
                //richTextBox1.Text += $"第 {round / 2 + 1} 回合\n";
                //点击之后才会输出 还是有点搞不清楚逻辑
                //落子的时候立马输出 所以应该是提示下一步而不是这一步
                //没有等待时间

                if (round % 2 == 0)
                {
                    richTextBox1.Text += $"第 {round / 2 + 1} 回合\n";
                    richTextBox1.Text += "请落黑子\n";
                    richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
                    richTextBox1.ScrollToCaret(); //Now scroll it automatically
                }
                else
                {
                    richTextBox1.Text += $"第 {round / 2 + 2} 回合\n";
                    richTextBox1.Text += "请落白子\n";
                    richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
                    richTextBox1.ScrollToCaret(); //Now scroll it automatically
                }
                var g = pictureBox1.CreateGraphics();
                //将指定屏幕点的位置计算成工作区坐标
                Point box1Point = pictureBox1.PointToClient(Control.MousePosition);
                //看鼠标点击靠近哪个点 好巧妙的思路
                int x = box1Point.X % single_width > single_width / 2 ? box1Point.X / single_width + 1 : box1Point.X / single_width;
                int y = box1Point.Y % single_width > single_width / 2 ? box1Point.Y / single_width + 1 : box1Point.Y / single_width;
                if (chessBoard[x, y] == 0)
                {
                    if (round % 2 == 0)
                    {
                        g.FillEllipse(Brushes.White, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                        round++;
                        chessBoard[x, y] = 1;//落下白子，chessboard设为1
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Black, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                        round++;
                        chessBoard[x, y] = 2;//落下黑子，chessboard设为2
                    }
                }
                else
                {
                    richTextBox1.Text += "请勿重复落子\n";
                    richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
                    richTextBox1.ScrollToCaret(); //Now scroll it automatically
                }
                start = SuccessCheck(x, y, out judge);

            }
            else  //不能落子，游戏结束
            {
                if (judge == 1)
                {
                    label1.Text = "白子胜利！\n";
                }
                else
                {
                    label1.Text = "黑子胜利！\n";
                }
            }
        }
        private void ToBottom(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret(); //Now scroll it automatically
        }


        /* 
         * 
         * 胜利检验 很有难度！
         * chessboard二维数组储存棋盘的状况 有白子的地方是1 黑子的地方是2 没子的地方是0
         * 判断中心棋子的四周
         * 返回游戏是否结束start 输出判断胜负的judge
         * 如何处理数组容易访问越界的问题？
         */
        private bool SuccessCheck(int x, int y, out int judge)
        {
            // 遍历 获取棋盘数组的每行
            for (int i = 0; i < chessBoard.GetLength(1); i++)
            {
                // 遍历 获取棋盘数组每行的每列
                for (int j = 0; j < chessBoard.GetLength(0); j++)
                {
                    // 判断是白子还是黑子
                    if (chessBoard[j, i] == 1)
                    {
                        // 水平判断
                        if (j < 10)
                        {
                            if (chessBoard[j + 1, i] == 1 && chessBoard[j + 2, i] == 1 && chessBoard[j + 3, i] == 1 && chessBoard[j + 4, i] == 1)
                            {
                                judge = 1;
                                return false;
                            }

                        }
                        // 垂直判断
                        if (i < 10)
                        {
                            if (chessBoard[j, i + 1] == 1 && chessBoard[j, i + 2] == 1 && chessBoard[j, i + 3] == 1 && chessBoard[j, i + 4] == 1)
                            {
                                judge = 1;
                                return false;
                            }

                        }
                        // 主对角线
                        if (j < 10 && i < 10)
                        {
                            if (chessBoard[j + 1, i + 1] == 1 && chessBoard[j + 2, i + 2] == 1 && chessBoard[j + 3, i + 3] == 1 && chessBoard[j + 4, i + 4] == 1)
                            {
                                judge = 1;
                                return false;
                            }

                        }
                        // 副对角线
                        if (j > 3 && i < 10)
                        {
                            if (chessBoard[j - 1, i + 1] == 1 && chessBoard[j - 2, i + 2] == 1 && chessBoard[j - 3, i + 3] == 1 && chessBoard[j - 4, i + 4] == 1)
                            {
                                judge = 1;
                                return false;
                            }

                        }
                    }//这里和平常写的不同，是j行i列！
                    //Bug真难找
                    else if (chessBoard[j,i] == 2)
                    {
                        // 水平判断
                        if (j < 10)
                        {

                            if (chessBoard[j + 1, i] == 2 && chessBoard[j + 2, i] == 2 && chessBoard[j + 3, i] == 2 && chessBoard[j + 4, i] == 2)
                            {
                                judge = 2;
                                return false;

                            }
                        }
                        // 垂直判断
                        if (i < 10)
                        {

                            if (chessBoard[j, i + 1] == 2 && chessBoard[j, i + 2] == 2 && chessBoard[j, i + 3] == 2 && chessBoard[j, i + 4] == 2)
                            {
                                judge = 2;
                                return false;
                            }
                        }
                        // 主对角线
                        if (j < 10 && i < 10)
                        {

                            if (chessBoard[j + 1, i + 1] == 2 && chessBoard[j + 2, i + 2] == 2 && chessBoard[j + 3, i + 3] == 2 && chessBoard[j + 4, i + 4] == 2)
                            {
                                judge = 2;
                                return false;
                            }
                        }
                        // 副对角线
                        if (j > 3 && i < 10)
                        {

                            if (chessBoard[j - 1, i + 1] == 2 && chessBoard[j - 2, i + 2] == 2 && chessBoard[j - 3, i + 3] == 2 && chessBoard[j - 4, i + 4] == 2)
                            {
                                judge = 2;
                                return false;
                            }
                        }
                    }
                }

            }
            judge = 0;
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
