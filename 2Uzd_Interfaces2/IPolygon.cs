using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Uzd_Interfaces2
{
    public interface IPolygon : IComparable<IPolygon>
    {
        double GetArea();
    }
}
