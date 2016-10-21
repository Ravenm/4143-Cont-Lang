using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    class Rectangle : Shape2D
    {
        public Rectangle(Point mainPoint, int height=0, int width=0, string name = "Rectangle", string type = "2D shape",
            string picture = "Images\\rectangle.png")
            : base(mainPoint, name, type, picture)
        {
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Sets the points in the list Points, They are set starting with 
        /// bottom left then go in clockwise fashion. Clears points list 
        /// every time to avoid stale data
        /// </summary>
        protected new void SetPoints()
        {
            if (Points.Count > 0)
            {
                Points.Clear();
            }
            Points.Add(MainPoint);

            Points.Add(new Point
            {
                X = MainPoint.X,
                Y = MainPoint.Y + Height
            });

            Points.Add(new Point
            {
                X = MainPoint.X + Width,
                Y = MainPoint.Y + Height
            });

            Points.Add(new Point
            {
                X = MainPoint.X + Width,
                Y = MainPoint.Y
            });
        }

        /// <summary>
        /// calls set points then returns that list
        /// </summary>
        /// <returns>Points</returns>
        public List<Point> GetPointList()
        {
            SetPoints();
            return Points;
        }

        public override void SetAttributes()
        {
            SetPoints();
            SetArea();
            SetPerimeter();
        }

        /// <summary>
        /// sets area
        /// </summary>
        protected new void SetArea()
        {
            Area = Height*Width;
        }

        /// <summary>
        /// set perimeter
        /// </summary>
        protected new void SetPerimeter()
        {
            Perimeter = Height*2 + Width*2;
        }

        public override string ToString()
        {
            var tempString = new StringBuilder();
            tempString.AppendLine("The shape type is" + Name);
            tempString.AppendLine("The main points are:");
            foreach (var point in Points)
            {
                tempString.AppendLine("point "+ point);
            }
            tempString.AppendLine("The area is" + Area);
            tempString.AppendLine("The perimeter is" + Perimeter);
            return tempString.ToString();
        }

    }
}