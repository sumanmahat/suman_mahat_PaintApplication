using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77202708_PaintApplication.NewFolder1
{
    class ShapeFactory
    {
        //use getShape method to get object of type shape 
        public Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.equalsIgnoreCase("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.equalsIgnoreCase("RECTANGLE"))
            {
                return new Rectangle();

            }
           

            return null;
        }
    }
}
