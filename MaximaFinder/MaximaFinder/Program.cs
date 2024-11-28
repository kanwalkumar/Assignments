using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 100; k++)
            {
                //Generating Random Rectangles
                Random random = new Random();
                List<cRectangle> cRectanglesList = new List<cRectangle>();
                for (int i = 0; i < 100; i++)
                {
                    cRectangle rect = new cRectangle(random.Next(1, 20), random.Next(1, 20)); //Generate Rectangles of random sizes
                    cRectanglesList.Add(rect);
                    Console.WriteLine("Rectangle has Area {0}, Length {1}, Height {2}", rect.Area, rect.Length, rect.Height);
                }
            }
            Console.ReadKey();
        }

        static cRectangle FindLargest_LinearComplexity(List<cRectangle> cRectanglesList)
        {
            //Finding Largest Rectangle
            cRectangle MaxRect = new cRectangle(0, 0);
            foreach (var item in cRectanglesList)
            {
                if (item.Area > MaxRect.Area)
                {
                    MaxRect = item;
                }
                else if (item.Area == MaxRect.Area && item.Height>MaxRect.Height) // Select max rectangle with max Height
                {
                    MaxRect = item;
                    //Console.WriteLine("Maximum Rectangle has same area but selected with Max height; Area {0}, Length {1}, Height {2}", item.Area, item.Length, item.Height);
                }
            }

            Console.WriteLine("Maximum Rectangle has Area {0}, Length {1}, Height {2}", MaxRect.Area, MaxRect.Length, MaxRect.Height);
         

            return MaxRect;
        }

    }
}
