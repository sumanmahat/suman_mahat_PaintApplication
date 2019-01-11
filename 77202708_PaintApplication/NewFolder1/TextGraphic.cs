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
    class TextGraphic : Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public string text { get; set; }
        public Color color { get; set; }

        /// <summary>
        /// to write text through command
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            Font fy = new Font("Helvetica", 10, FontStyle.Bold);
            Brush br = new SolidBrush(color);
            g.DrawString(text, fy, br, new Point(x, y));
            br.Dispose();
            fy.Dispose();
        }

        public void SetParam(int x, int y, int width, int height, Color color, bool isFilled, string text, Point pointX, Point pointY)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.text = text;
        }
    }
}
