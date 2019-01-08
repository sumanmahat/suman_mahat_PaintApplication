﻿using _7202708_PaintApplication.NewFolder1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Lines : Shape
    {
        public Point pointX { get; set; }
        public Point pointY { get; set; }
        public Color color { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 1);
            g.DrawLine(pen, pointX, pointY);
            pen.Dispose();
        }

        public void SetParam(int x, int y, int width, int height, Color color, bool isFilled, string text, Point pointX, Point pointY)
        {
            this.color = color;
            this.pointX = pointX;
            this.pointY = pointY;
        }
    }
}
