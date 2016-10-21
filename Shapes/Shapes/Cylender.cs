using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    class Cylender : Shape3D
    {
        protected Circle Face;

        public Cylender(Point mainPoint, int radius = 0, int depth = 0, string name = "Cylinder",
            string type = "3D Shape",
            string picture = "Images\\cylinder.png")
            : base(mainPoint, radius, 0, depth, name, type, picture)
        {
            Face = new Circle(mainPoint, radius, name, type, picture);
        }

        protected new void SetVolume()
        {
            Volume = Face.GetArea()*Depth;
        }

        protected new void SetSurface()
        {
            Surface = Face.GetPerimeter()*Depth + Face.GetArea();
        }

        public override void SetAttributes()
        {
            Face = new Circle(MainPoint, Radius);
            Face.SetAttributes();
            SetSurface();
            SetVolume();
        }

        public override string ToString()
        {
            var tempString = new StringBuilder();
            tempString.AppendLine("The shape type is " + Name);
            tempString.AppendLine("The main points are:");
            tempString.AppendLine("Base centered at " + "(" + MainPoint.X + ", " + MainPoint.Y + ", " + 0 + ")");
            tempString.AppendLine("Base centered at " + "(" + MainPoint.X + ", " + MainPoint.Y + ", " + Depth + ")");
            tempString.AppendLine("The surface area is" + Surface);
            tempString.AppendLine("The Volume is" + Volume);
            return tempString.ToString();
        }
    }
}
