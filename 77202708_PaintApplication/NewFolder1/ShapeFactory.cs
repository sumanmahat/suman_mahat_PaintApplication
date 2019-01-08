using _7202708_PaintApplication.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            Shape shape = null;
            switch (shapeType)
            {
                case "CIRCLE":
                    shape = new Circle();
                    break;
                case "RECTANGLE":
                    shape = new Rectangles();
                    break;
                case "LINE":
                    shape = new Lines();
                    break;
                case "STRING":
                    shape = new TextGraphic();
                    break;
            }
            return shape;
        }
    }
}
