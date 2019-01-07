using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Serializable]
    class Circle
    {
        public Circle(int x, int y, int radius, bool isFilled, Color color)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.isFilled = isFilled;
            this.color = color;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int radius { get; set; }
        public bool isFilled { get; set; }
        public Color color { get; set; }
    }
}
