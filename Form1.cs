using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 定时器
        /// </summary>
        Timer m_timer;     
        /// <summary>
        /// 画布模型
        /// </summary>
        Canvas m_canvas;
        /// <summary>
        /// 画布
        /// </summary>
        Graphics m_picturegra;
        /// <summary>
        /// 用于显示下一个砖块的画布
        /// </summary>
        Graphics m_nextpicgra;
        float m_itemxlength;
        float m_itemylength;
        bool m_isrun;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Tetris!";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            pictureBox1.Focus();

            label1.Size = new Size(140, 120);
            label1.Location = new Point(440, 140);
            label1.Font = new Font("微软雅黑",8);
            label1.Text = "游戏说明：\n   通过方向键控制砖块。\n   向上键：变形\n   向左键：左移\n   向下键：下移\n   向右键：右移\n   小键盘0：掉到最低";

            label2.AutoSize = false;
            label2.Location = new Point(440, 280);
            label2.Size = new Size(140, 30);
            label2.Text = "当前分数：0分";

            Btn_NewGame.Location = new Point(440, 320);
            Btn_NewGame.Size = new Size(140, 20);

            Btn_Stop.Location = new Point(440, 350);
            Btn_Stop.Size = new Size(140, 20);

            Btn_Continue.Location = new Point(440, 380);
            Btn_Continue.Size = new Size(140, 20);

            Btn_Quit.Location = new Point(440, 410);
            Btn_Quit.Size = new Size(140, 20);

            m_picturegra = pictureBox1.CreateGraphics();
            m_canvas = new Canvas();
            m_itemxlength = pictureBox1.Width / m_canvas.m_columns;
            m_itemylength = pictureBox1.Height / m_canvas.m_rows;

            pictureBox2.Size = new Size((int)m_itemxlength * 5, (int)m_itemylength * 5);
            m_nextpicgra = pictureBox2.CreateGraphics();

            m_isrun = false;

            m_timer = new Timer();
            m_timer.Interval = 500;
            m_timer.Enabled = false;
            m_timer.Tick += new EventHandler(m_timer_Tick);
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            if (m_canvas.Run() == true)
            {
                //pictureBox1.Refresh();
                Draw();
                DrawNext();
                DrawScore();
            }
            else
            {
                m_timer.Enabled = false;
                if (m_canvas.m_score >= 100)
                {
                    MessageBox.Show("游戏结束！胜利！");
                }
                else
                {
                    MessageBox.Show("游戏结束！失败！");
                }
            }
        }

        private void Draw()
        {
            //初始化画布
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gb = Graphics.FromImage(canvas);

            for (int i = 0; i < m_canvas.m_rows; i++)
            {
                for (int j = 0; j < m_canvas.m_columns; j++)
                {
                    if (m_canvas.m_arr[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        DrawItem(gb, i, j);
                    }
                }
            }
            pictureBox1.BackgroundImage = canvas;
            pictureBox1.Refresh();
        }

        private void DrawItem(Graphics gb, int row, int column)
        {
            float xpos = column * m_itemxlength-1;
            float ypos = row * m_itemylength-1;
            gb.FillRectangle(Brushes.Blue, xpos, ypos, m_itemxlength-2, m_itemylength-2);
        }

        private void DrawNext()
        {
            pictureBox2.Refresh();
            m_canvas.DrawNewxBrick(m_nextpicgra, m_itemxlength, m_itemylength);
        }

        private void DrawScore()
        {
            string text = "当前的分数：" + m_canvas.m_score.ToString() + "分";
            label2.Text = text;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (m_isrun == true)
            {
                if (key == Keys.Up)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickUp();
                    Draw();
                }
                if (key == Keys.Left)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickLeft();
                    Draw();
                }
                if (key == Keys.Right)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickRight();
                    Draw();
                }
                if (key == Keys.Down)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickDown();
                    Draw();
                }
                if(key == Keys.NumPad0)
                {
                    pictureBox1.Refresh();
                    m_canvas.BrickFall();
                    //Draw();
                    //DrawNext();
                    //DrawScore();
                }
            }
        }

        //新局
        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            m_isrun = false;
            m_timer.Stop();

            m_canvas = new Canvas();

            m_isrun = true;
            m_timer.Start();
        }

        //暂停
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            m_isrun = false;
            m_timer.Stop();
        }

        //继续
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            m_isrun = true;
            m_timer.Start();
        }

        //退出
        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
