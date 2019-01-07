using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Serializable]
    class Rectangle
    {
        public Rectangle(int x, int y, int width, int height, bool isFilled, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.isFilled = isFilled;
            this.color = color;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool isFilled { get; set; }
        public Color color { get; set; }

        public Rectangle GetRectangle()
        {
            return new Rectangle(x, y, width, height);
        }
    }
}
