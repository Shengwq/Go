using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class PVE : Form
    {
        private const int size = 13;
        private const int single_width = 50;
        const int width = single_width * size;
        private int[,] chessBoard = new int[size + 1, size + 1];
        private int r = 20;
        Point original_point = new Point(0, 0);
        static Point myPoint = new Point(0, 0);
        private bool start;
        private int round;
        private int judge = 0;

        public PVE()
        {
            InitializeComponent();
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


        private void button3_Click(object sender, EventArgs e)
        {
            PVESelect selectPage = new PVESelect();
            selectPage.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
             * 
             * if else 逻辑链有点长。。。有点难配对
             */
            //如果游戏进行中，则可以落子
            if (start)
            {
                //richTextBox1.Text += $"第 {round / 2 + 1} 回合\n";
                //点击之后才会输出 还是有点搞不清楚逻辑
                //落子的时候立马输出 所以应该是提示下一步而不是这一步
                //没有等待时间

                //if (round % 2 == 0)
                //{
                //    richTextBox1.Text += $"第 {round / 2 + 1} 回合\n";
                //    richTextBox1.Text += "请落黑子\n";
                //    richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
                //    richTextBox1.ScrollToCaret(); //Now scroll it automatically
                //}
                if (round % 2 == 0)//人机对战 round 永远是偶数
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
                    //回合判断也不需要了
                    //但是程序容易崩
                    //if (round % 2 == 0)
                    //{
                    g.FillEllipse(Brushes.White, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                    round++;
                    chessBoard[x, y] = 1;//落下白子，chessboard设为1
                                         //这里其实不需要用静态变量存储了
                                         //myPoint.X = x;
                                         //myPoint.Y = y;
                    if (LittleAI(ref x, ref y))
                    {
                        goto Label1;
                    }

                /*
                 * 改了下程序的逻辑，减少了判断
                 * 马上就不崩了，代码也优雅了很多！
                 * 编程思路果然重要！
                 */
                Label:
                    Random random = new Random();
                    int seed = random.Next(1, 8);
                    if (seed == 1 && x > 0 && y > 0)
                    {
                        x = x - 1;
                        y = y - 1;
                    }
                    else if (seed == 2 && y > 0)
                    {
                        y = y - 1;
                    }
                    else if (seed == 3 && x < size && y > 0)
                    {
                        x = x + 1;
                        y = y - 1;
                    }
                    else if (seed == 4 && x > 0)
                    {
                        x = x - 1;
                    }
                    else if (seed == 5 && x < size)
                    {
                        x = x + 1;
                    }
                    else if (seed == 6 && x > 0 && y < size)
                    {
                        x = x - 1;
                        y = y + 1;
                    }
                    else if (seed == 7 && y < size)
                    {
                        y = y + 1;
                    }
                    else if (seed == 8 && x < size && y < size)
                    {
                        x = x + 1;
                        y = y + 1;
                    }
                Label1:
                    if (NoChess(x, y))//TODO 改进NoChess函数
                    {
                        g.FillEllipse(Brushes.Black, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                        round++;
                        chessBoard[x, y] = 2;//落下黑子，chessboard设为2
                    }
                    else
                    {
                        goto Label;
                    }
                    //else
                    //{
                    //Label:
                    //    int randX = random.Next(0, size);
                    //    int randY = random.Next(0, size);
                    //    if (NoChess(x, y))
                    //    {
                    //        x = randX;
                    //        y = randY;
                    //    }
                    //    else
                    //    {
                    //        goto Label;
                    //    }
                    //}
                    //g.FillEllipse(Brushes.Black, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                    //round++;
                    //chessBoard[x, y] = 2;//落下黑子，chessboard设为2

                    //else
                    //{
                    //Random random = new Random();
                    //int seed =random.Next(1,8);
                    //if (seed == 1 && myPoint.X > 0 && myPoint.Y > 0 && NoChess(myPoint.X-1,myPoint.Y-1))
                    //{
                    //    x=myPoint.X-1;
                    //    y=myPoint.Y-1;
                    //}
                    //else if(seed == 2 &&myPoint.Y>0&&NoChess(myPoint.X,myPoint.Y-1))
                    //{
                    //    x = myPoint.X;
                    //    y = myPoint.Y-1;
                    //}
                    //else if(seed == 3 && myPoint.X<size&&myPoint.Y>0&&NoChess(myPoint.X+1,myPoint.Y-1))
                    //{
                    //    x= myPoint.X+1;
                    //    y=myPoint.Y-1;
                    //}
                    //else if (seed == 4 && myPoint.X>0&&NoChess(myPoint.X-1,myPoint.Y))
                    //{
                    //    x = myPoint.X -1;
                    //    y = myPoint.Y ;
                    //}
                    //else if (seed == 5 && myPoint.X<size&&NoChess(myPoint.X+1,myPoint.Y))
                    //{
                    //    x = myPoint.X +1;
                    //    y = myPoint.Y ;
                    //}
                    //else if (seed == 6 && myPoint.X>0&&myPoint.Y<size&&NoChess(myPoint.X-1,myPoint.Y+1))
                    //{
                    //    x = myPoint.X-1;
                    //    y = myPoint.Y +1;
                    //}
                    //else if (seed == 7 && myPoint.Y<size&&NoChess(myPoint.X,myPoint.Y+1))
                    //{
                    //    x = myPoint.X ;
                    //    y = myPoint.Y + 1;
                    //}
                    //else if (seed == 8 && myPoint.X<size&&myPoint.Y<size&&NoChess(myPoint.X+1,myPoint.Y+1))
                    //{
                    //    x = myPoint.X + 1;
                    //    y = myPoint.Y +1;
                    //}
                    //else
                    //{

                    //Label: 
                    //     int randX = random.Next(0, size);
                    //    int randY= random.Next(0, size);
                    //     if (NoChess(x, y))
                    //     {
                    //         x=randX;
                    //         y=randY;
                    //     }
                    //     else
                    //     {
                    //         goto Label;
                    //     }


                    //}

                    //    g.FillEllipse(Brushes.Black, x * single_width - r, y * single_width - r, 2 * r, 2 * r);
                    //    round++;
                    //    chessBoard[x, y] = 2;//落下黑子，chessboard设为2
                    //}
                    //}


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
                    richTextBox1.Text += "恭喜您战胜电脑！\n";
                }
                else
                {
                    label1.Text = "黑子胜利！\n";
                    richTextBox1.Text += "别灰心，再来一局吧！\n";
                }
            }
        }
        /*
         * Debug真的不容易
         * NoChess函数开始竟然写错了
        */
        private bool NoChess(int x, int y)
        {
            if (chessBoard[x, y] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
                    else if (chessBoard[j, i] == 2)
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
        //电脑的小智能 堵你三连珠
        private bool LittleAI(ref int x, ref int y)
        {
            // 遍历 获取棋盘数组的每行
            for (int i = 0; i < chessBoard.GetLength(1); i++)
            {
                // 遍历 获取棋盘数组每行的每列
                for (int j = 0; j < chessBoard.GetLength(0); j++)
                {
                    if (chessBoard[j, i] == 1)
                    {
                        // 水平判断
                        if (j < 11 && j > 0)
                        {
                            if (chessBoard[j + 1, i] == 1 && chessBoard[j + 2, i] == 1)
                            {
                                if (NoChess(j - 1, i))
                                {
                                    x = j - 1;
                                    y = i;
                                    return true;
                                }
                                else if (NoChess(j + 3, i))
                                {
                                    x = j + 1;
                                    y = i;
                                    return true;
                                }

                            }


                        }
                        // 垂直判断
                        if (i < 11 && i > 0)
                        {
                            if (chessBoard[j, i + 1] == 1 && chessBoard[j, i + 2] == 1)
                            {
                                if (NoChess(j, i - 1))
                                {
                                    x = j;
                                    y = i - 1;
                                    return true;
                                }
                                else if (NoChess(j, i + 3))
                                {
                                    x = j;
                                    y = i + 3;
                                    return true;
                                }
                            }

                        }
                        // 主对角线
                        if (j < 11 && j > 0 && i < 11 && i > 0)
                        {
                            if (chessBoard[j + 1, i + 1] == 1 && chessBoard[j + 2, i + 2] == 1)
                            {
                                /*
                                 * 真的烧脑
                                 * NoChess函数能判断数组越界问题就好了
                                 * 我的程序还是可维护性差
                                 */
                                if (NoChess(j - 1, i - 1))
                                {
                                    x = j - 1;
                                    y = i - 1;
                                    return true;
                                }
                                else if (NoChess(j + 3, i + 3))
                                {
                                    x = j + 3;
                                    y = i + 3;
                                    return true;
                                }

                            }

                        }
                        // 副对角线
                        if (j > 2 && j < 13 && i < 11 && i > 0)
                        {
                            if (chessBoard[j - 1, i + 1] == 1 && chessBoard[j - 2, i + 2] == 1)
                            {
                                if (NoChess(j - 3, i + 3))
                                {
                                    x = j - 3;
                                    y = i + 3;
                                    return true;
                                }
                                else if (NoChess(j + 1, i - 1))
                                {
                                    x = j + 1;
                                    y = i - 1;
                                    return true;
                                }

                            }

                        }

                    }//这里和平常写的不同，是j行i列！
                }
            }
            return false;
            //遍历完成之后return即可
        }

    
    }
}
