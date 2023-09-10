//
//using Baseline.ImTools;

using System.Security.Cryptography;

namespace ConsoleApp3;
internal class Program
{
    static void Main(string[] args)
    {

        //Point3D P = new Point3D(10, 10, 10);
        //Console.WriteLine(P.ToString());

        ////////////user points////////

        //double x1, y1, z1, x2, y2, z2;

        //Console.Write("Enter x of P1: ");
        //if (!double.TryParse(Console.ReadLine(), out x1))
        //{
        //    Console.WriteLine(" Please enter a valid number.");
        //    return;
        //}

        //Console.Write("Enter y of P1: ");
        //if (!double.TryParse(Console.ReadLine(), out y1))
        //{
        //    Console.WriteLine(" Please enter a valid number.");
        //    return;
        //}

        //Console.Write("Enter  z of P1: ");
        //if (!double.TryParse(Console.ReadLine(), out z1))
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid number.");
        //    return;
        //}

        //Console.Write("Enter x of P2: ");
        //if (!double.TryParse(Console.ReadLine(), out x2))
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid number.");
        //    return;
        //}

        //Console.Write("Enter  y of P2: ");
        //if (!double.TryParse(Console.ReadLine(), out y2))
        //{
        //    Console.WriteLine(" Please enter a valid number.");
        //    return;
        //}

        //Console.Write("Enter z of P2: ");
        //if (!double.TryParse(Console.ReadLine(), out z2))
        //{
        //    Console.WriteLine("Please enter a valid number.");
        //    return;
        //}


        //Point3D P1 = new Point3D((int)x1, (int)y1, (int)z1);
        //Point3D P2 = new Point3D((int)x2, (int)y2, (int)z2);



        ///Array of 3 points///



        //Point3D[] point = new Point3D[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine("Enter the X coordinate for point {0}: ", i + 1);
        //    int x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the Y coordinate for point {0}: ", i + 1);
        //    int y = int.Parse(Console.ReadLine());
        //    point[i] = new Point3D { X = x, Y = y };

        //}
        //Console.WriteLine("The first point is ({0}, {1})", point[0].X, point[0].Y);

        //Console.WriteLine("The second point is ({0}, {1})", point[1].X, point[1].Y);

        //Console.WriteLine("The third point is now ({0}, {1})", point[2].X, point[2].Y);


        //  / duration objects//////




        duration d1 = new duration(1, 30, 20);
        Console.WriteLine("first duration is =>" + (d1));


        duration d2 = new duration(3600);
        Console.WriteLine("second duration is =>" + (d2));


        duration d3 = new duration(7800);
        Console.WriteLine("third duration is =>" + (d3));


        duration d4 = new duration(666);
        Console.WriteLine("fourth duration is =>" + (d4));

        // duration d5 = new duration();         // why???
        duration d5 = d1 + d2;

        Console.WriteLine("fifth duration is =>" + d5.ToString());

        duration d6 = d1 + 7800;
        Console.WriteLine("6th duration is =>" + (d6));






        //  ///////////////

        duration d7 = d1 + 60;
        Console.WriteLine("7th duration is =>" + (d7));   ///why without operator ++


        duration d8 = --d2;                   ////why not with d2-60
        Console.WriteLine("8th duration is =>" + (d8));


        ////////////




        //d1>d2

        if (d1 > d2)
        {
            Console.WriteLine("d1 is more than d2");
        }
        else
        {
            Console.WriteLine("d1 is less than d2");
        }

        ///D1<=D2  
        if (d1 < d2)
        {
            Console.WriteLine("d2 is more than d1");
        }
        else
        {
            Console.WriteLine("d2 is less than d1");
        }

        ////sorting 
        


    }




}






