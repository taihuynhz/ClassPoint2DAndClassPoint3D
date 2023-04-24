using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint2DAndClassPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point2D Test
            Point2D[] point2D = new Point2D[2];

            point2D[0] = new Point2D();
            point2D[1] = new Point2D(1f, 2.5f);

            Console.WriteLine("Point2D test");
            foreach (Point2D item in point2D)
            {
                Console.WriteLine(item);
            }

            // Point3D Test
            Point3D[] point3D = new Point3D[2];

            point3D[0] = new Point3D();
            point3D[1] = new Point3D(3f, 4.5f, 5f);

            Console.WriteLine("Point3D test");
            foreach (Point3D item in point3D)
            {
                Console.WriteLine(item);
            }
        }
    }
}
