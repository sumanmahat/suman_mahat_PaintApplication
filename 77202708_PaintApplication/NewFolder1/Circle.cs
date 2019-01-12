using _7202708_PaintApplication.NewFolder1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Serializable]
    class Circle : Shape
    {
        /// <summary>
        /// getter setter methods
        /// </summary>

        public int x { get; set; }
        public int y { get; set; }
        public int radius { get; set; }
        public bool isFilled { get; set; }
        public Color color { get; set; }


        /// <summary>
        /// method to draw circle 
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            if (isFilled)
            {
                Brush br = new SolidBrush(color);
                g.FillEllipse(br, new Rectangle(x, y, radius, radius));
                br.Dispose();
            }
            else
            {
                Pen pen = new Pen(color, 1);
                g.DrawEllipse(pen, new Rectangle(x, y, radius, radius));
                pen.Dispose();
            }
        }

        /// <summary>
        /// parameter to draw circle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="color"></param>
        /// <param name="isFilled"></param>
        /// <param name="text"></param>
        /// <param name="pointX"></param>
        /// <param name="pointY"></param>
        public void SetParam(int x, int y, int width, int height, Color color, bool isFilled, string text, Point pointX, Point pointY)
        {
            this.x = x;
            this.y = y;
            this.radius = width;
            this.color = color;
            this.isFilled = isFilled;
        }
    }
}
