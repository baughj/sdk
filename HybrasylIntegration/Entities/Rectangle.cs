using System;
using System.Collections.Generic;
using System.Text;

namespace Hybrasyl.Entities
{
    public class Rectangle
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int Left => X;
        public int Right => X + Width;
        public int Top => Y;
        public int Bottom => Y + Height;

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public bool Contains(Rectangle rect)
        {
            var maxX = X + Width;
            var maxY = Y + Height;

            return X <= rect.X && ((rect.X + rect.Width) <= maxX) && Y <= rect.Y && ((rect.Y + rect.Height) <= maxY);
        }

        public bool IntersectsWith(Rectangle rect)
        {
            return (rect.X < X + Width) &&
            (X < (rect.X + rect.Width)) &&
            (rect.Y < Y + Height) &&
            (Y < rect.Y + rect.Height);
        }
    }

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
