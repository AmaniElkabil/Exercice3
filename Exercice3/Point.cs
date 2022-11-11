using System;
using System.Configuration;

namespace Plan
{
    public class Point
    {
        private int X, Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int GetX()
        {
            return X;
        }

        public void SetX(int X)
        {
            this.X = X;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetY(int Y)
        {
            this.Y = Y;
        }

        public double Distance(Point P)
        {
            return Math.Sqrt(Math.Pow((P.GetX() - this.GetX()), 2) + Math.Pow((P.GetY() - this.GetY()), 2));
        }

        public int Egal(Point P)
        {
            if ((P.X == X) && (P.Y == Y))
                return 1;
            else
                return 0;
        }
        public void Translation(int dX, int dY)
        {
            X += dX;
            Y += dY;
        }
        public int lineair(Point P1, Point P2)
        {
            if ((P1.X - this.X) / (P2.X - this.X) == (P1.Y - this.Y) / (P2.Y - this.Y))
                return 1;
            else
                return 0;
        }
    }
}