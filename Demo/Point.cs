using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y) {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (X ==other.X) return Y.CompareTo(other.Y);
                return X.CompareTo(other.X);
            }
                return 1;
            }

        public int CompareTo(object? obj)
        {
            // 1. is Conditional Operator
            if (obj is not null)
            {
                if (obj is Point P)
                { 
                    //Point P (Point)obj;

                    if (X==P.X) return Y.CompareTo(P.Y);

                return X.CompareTo(P.X);
            }
        }
          return 1;
        }
        public int CompareTo(object? obj)
        {
            // 2. as Casting Operator

        Point p = obj as Point;
           if (p is not null)
            {
                if (X == p.X) return Y.CompareTo(p.Y);
              return X.CompareTo(p.X);
        }
            return 1;
        }
    }
}
