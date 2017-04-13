﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Box
    {
        public int x, y, size, speed;
        public Box(int _x,int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
        public void Move()
        {
            y = y + speed;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - speed;
            }
            if (direction == "right")
            {
                x = x + speed;
            }
            if (direction == "up")
            {
                y = y - speed;
            }
            if (direction == "down")
            {
                y = y + speed;
            }


            if (x < 0 || x > 860)
            {
                x = 1;
            }
            if (y < 0 )
            {
                y = 1;
            }
            if (y > 500 - size)
            {
                y = 480;
            }
        }

        
        public Boolean Collision(Box b)
        {
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle heroRec = new Rectangle(x, y, size, size);

            return boxRec.IntersectsWith(heroRec);
        }

    }
}
