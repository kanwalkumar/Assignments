using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaFinder
{
    public class cRectangle
    {
        public cRectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public double Length { get; set; }
        public double Height { get; set; }

        public double Area => Length * Height; 

    }
}
