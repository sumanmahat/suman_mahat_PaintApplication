using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Lines
    {
        public Lines(Point pointX, Point pointY, Color color)
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.color = color;
        }
        public Point pointX { get; set; }
        public Point pointY { get; set; }
        public Color color { get; set; }
    }
}
