using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Uzd_Interfaces2
{
    public class Triangle : IPolygon
    {
        public int Base { get; set; }
        public int Heigth { get; set; }

        public int CompareTo(IPolygon? other)
        {
           if( GetArea() > other.GetArea())
            {
                return 1;
            }
           else if (GetArea() == other.GetArea())
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public double GetArea()
        {
            return Base * Heigth;
        }
    }
}
