using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }
    }
}
