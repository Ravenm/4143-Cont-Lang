using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    class Cube : Box
    {
        public Cube(Point mainPoint, int height = 0, string name = "Cube", string type = "3D Shape", string picture = "Images\\cube.png")
            : base(mainPoint, height, height, height, name, type, picture)
        {
            Face = new Square(mainPoint, height);
        }

        /// <summary>
        /// make sure depth and width are set correctly
        /// </summary>
        public override void SetAttributes()
        {
            Width = Height;
            Depth = Height;
            Face = new Square(MainPoint , Height);
            Face.SetAttributes();
            SetPoints();
            SetSurface();
            SetVolume();
        }
    }
}
