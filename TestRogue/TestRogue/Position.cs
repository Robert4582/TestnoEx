using Microsoft.Xna.Framework;
using Roy_T.AStar.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public struct Position
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

        public Position(Roy_T.AStar.Primitives.Position position)
        {
            x = (int)position.X;
            y = (int)position.Y;
        }

        public static implicit operator GridPosition(Position pos)
        {
            return new GridPosition(pos.x, pos.y);
        }

        public static implicit operator Point(Position pos)
        {
            return new Point(pos.x, pos.y);
        }

        public static Position operator *(Position position, int multiply)
        {
            return new Position(position.x * multiply, position.y * multiply);
        }

        public static Position operator +(Position position, Position nextPosition)
        {
            return new Position(position.x + nextPosition.x, position.y + nextPosition.y);
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
