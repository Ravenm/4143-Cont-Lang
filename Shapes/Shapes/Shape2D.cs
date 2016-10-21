using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape2D:Shape
    {
        protected double? Area = null;
        protected double? Perimeter = null;
        protected List<Point> Points = new List<Point>();

        public Shape2D()
        {
            
        }

        public Shape2D(Point mainPoint, string name, string type, string picture)
        {
            MainPoint = mainPoint;
            Name = name;
            Type = type;
            Picture = picture;
        }
        public double GetArea()
        {
            SetArea();
            return (double) (Area ?? 0);
        }

        public override void SetAttributes()
        {
            SetPoints();
            SetArea();
            SetPerimeter();
        }

        protected void SetPoints()
        {

        }

        public double GetPerimeter()
        {
            SetPerimeter();
            return (double) (Perimeter ?? 0);
        }

        protected void SetArea()
        {

        }

        protected void SetPerimeter()
        {
            
        }
    }
}
