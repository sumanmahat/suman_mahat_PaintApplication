using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Serializable]
    class Polygon
    {
        List<Point> listPoints;
        public Polygon(Color color, bool isFilled)
        {
            this.color = color;
            this.isFilled = isFilled;
            listPoints = new List<Point>();
        }
        public Color color { get; set; }
        public bool isFilled { get; set; }
        public void addPoint(Point p)
        {
            listPoints.Add(p);
        }   

        public List<Point> getPoint()
        {
            return listPoints;

        }
    }
}