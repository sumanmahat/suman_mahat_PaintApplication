using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77202708_PaintApplication
{
   public class MethodCheckingPolygon
    {
        public bool isCircle(string shape)
        {
            if (shape == "POLYGON")
            {
                return true;
            }
            return false;
        }
    }
}
