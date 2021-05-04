using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public class Position
    {
        private int x;
        private int y;

        public int X { get => x; }
        public int Y { get => y; }

        public Position(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void SetPosition(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public void SetPosition(Position pos)
        {
            x = pos.x;
            y = pos.y;
        }

        public void OffsetPosition(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public void OffsetPosition(Position offsetPos)
        {
            x += offsetPos.x;
            y += offsetPos.y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Position)
            {
                return x == ((Position)obj).x && y == ((Position)obj).y;
            }
            return false;
        }

    }
}
