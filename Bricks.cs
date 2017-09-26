using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tetris
{
    class Bricks
    {
        public static ArrayList BrickList = new ArrayList();
        

        //随机获取一个砖块
        public static Brick GetBrick()
        {
            Random random = new Random();
            int index = random.Next(7);
            Brick brick;
            switch (index)
            {
                case 0:
                    brick = new Brick1();
                    break;
                case 1:
                    brick = new Brick2();
                    break;
                case 2:
                    brick = new Brick3();
                    break;
                case 3:
                    brick = new Brick4();
                    break;
                case 4:
                    brick = new Brick5();
                    break;
                case 5:
                    brick = new Brick6();
                    break;
                case 6:
                    brick = new Brick7();
                    break;
                default:
                    brick = new Brick1();
                    break;
            }
            return brick;
        }
    }
}
