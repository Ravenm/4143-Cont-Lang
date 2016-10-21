using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape2D
    {
        public Circle(Point mainPoint, int radius= 0, string name = "Circle", string type = "2D Shape", string picture = "Images\\circle.png")
            : base(mainPoint, name, type, picture)
        {
            Radius = radius;
        }

        public new void SetPoints()
        {
            Points.Add(MainPoint);
        }

        public new void SetArea()
        {
            Area = Math.PI*Math.Pow(Radius, 2);
        }

        public new void SetPerimeter()
        {
            Perimeter = 2*Math.PI*Radius;
        }

        public override void SetAttributes()
        {
            SetPoints();
            SetArea();
            SetPerimeter();
        }

        /// <summary>
        /// override print method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var tempString = new StringBuilder();
            tempString.AppendLine("The shape type is" + Name);
            tempString.AppendLine("The center point is:" + MainPoint);
            tempString.AppendLine("The radius is " + Radius);
            tempString.AppendLine("The area is" + Area);
            tempString.AppendLine("The perimeter is" + Perimeter);
            return tempString.ToString();
        }
    }
}
