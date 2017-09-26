using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    public abstract class Brick
    {
        protected int m_curTransforIndex;  //当前变形次序 
        public int m_needfulRows;       //必要的行数
        public int m_needfulColumns;    //必要的列数
        public int[,] m_range;     //变形范围
        public Point m_center;       //中心点(相对于必要区域)
        public Point m_Pos;      //中心点的位置(相对于画布)

        /// <summary>
        /// 能否变形（能变形的条件为在砖块的变形范围内不能有其他砖块）
        /// </summary>
        /// <param name="arr">画布模型</param>
        /// <param name="rows">画布行数</param>
        /// <param name="columns">画布列数</param>
        /// <returns></returns>
        public abstract bool CanTransform(int[,] arr, int rows, int columns);

        /// <summary>
        /// 变形
        /// </summary>
        public abstract void Transform();

        /// <summary>
        /// 能否左移
        /// </summary>
        /// <param name="arr">画布模型</param>
        /// <param name="rows">画布行数</param>
        /// <param name="columns">画布列数</param>
        /// <returns></returns>
        public abstract bool CanLeftMove(int[,] arr, int rows, int columns);

        /// <summary>
        /// 左移
        /// </summary>
        public void LeftMove()
        {
            m_Pos.Y -= 1;
        }

        /// <summary>
        /// 能否右移
        /// </summary>
        /// <param name="arr">画布模型</param>
        /// <param name="rows">画布行数</param>
        /// <param name="columns">画布列数</param>
        /// <returns></returns>
        public abstract bool CanRightMove(int[,] arr, int rows, int columns);

        /// <summary>
        /// 右移
        /// </summary>
        public void RightMove()
        {
            m_Pos.Y += 1;
        }

        /// <summary>
        /// 能否下移
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public abstract bool CanDropMove(int[,] arr, int rows, int columns);

        /// <summary>
        /// 下移
        /// </summary>
        public void DropMove()
        {
            m_Pos.X += 1;
        }

        public void KeyDownMove()
        {
            DropMove();
        }
        
        /// <summary>
        /// 随机生成一个可以通过变形得到的形状
        /// </summary>
        public void RandomShape()
        {
            Random random = new Random();
            this.m_curTransforIndex = random.Next(4);
            this.Transform();
        }

        /// <summary>
        /// 设置中心点相对于画布的位置
        /// </summary>
        /// <param name="x">横向位置</param>
        /// <param name="y">纵向位置</param>
        public void SetCenterPos(int x, int y)
        {
            this.m_Pos = new Point(x, y);
        }

        /// <summary>
        /// 获取砖块出现时中心点的Y轴坐标
        /// </summary>
        /// <returns></returns>
        public abstract int Appear();
    }
}
