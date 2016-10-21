using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(Point mainPoint, int height=0, string name = "Square", string type = "2d Shape", string picture = @"Images\square.png")
            : base(mainPoint, height, height, name, type, picture)
        {
        }

        /// <summary>
        /// make sure width and height are equal
        /// </summary>
        public override void SetAttributes()
        {
            Width = Height;
            SetPoints();
            SetArea();
            SetPerimeter();
        }



    }
}
