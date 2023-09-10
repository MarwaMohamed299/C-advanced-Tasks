using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Point3D;

namespace ConsoleApp3
{

    public class Point3D
    {
        int p1;
        int p2;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() 
        {
            X=Y=Z=0;
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
      
        public static bool operator == (Point3D p1, Point3D  p2)
        {
            return p1 == p2;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1 != p2;
        }
        ///sorting
        public int CompareTo(object? obj)
        {
            var right = obj as Point3D;
            if (this.X == this.X)
            {
                return this.Y.CompareTo(right.Y);
            }
            return this.X.CompareTo(right.X); 
               
        }
        ///clone
        public object clone()
        {
            return new Point3D { X = this.X, Y=this.Y, Z=this.Z };
        }
      


    }
    
}



    




