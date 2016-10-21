using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Box : Shape3D
    {
        protected Rectangle Face;

        public Box(Point mainPoint, int height, int width, int depth, string name = "Box", string type = "3D Shape",
            string picture = "Images\\box.png")
            : base(mainPoint, height,width, depth, name, type, picture)
        {
            Face = new Rectangle(mainPoint, height, width);
            Height = height;
            Width = width;
            Depth = depth;
        }

        /// <summary>
        /// calls set points then returns that list
        /// </summary>
        /// <returns>Points</returns>
        public List<Point3D> GetPointList()
        {
            SetPoints();
            return Points;
        }

        /// <summary>
        /// sets the points first from the face in clockwise fashion then
        /// lists the back in clockwise fashion
        /// </summary>
        protected void SetPoints()
        {
            if (Points.Count > 0)
            {
                Points.Clear();
            }
            var facePoints = Face.GetPointList();
            for (var i = 0; i < 4; i++)
            {
                Points.Add(new Point3D(facePoints[i].X, facePoints[i].Y));
            }
            for (var i = 0; i < 4; i++)
            {
                Points.Add(new Point3D(facePoints[i].X, facePoints[i].Y, Depth));
            }
        }

        /// <summary>
        /// set face values
        /// </summary>
        public override void SetAttributes()
        {
            Face = new Rectangle(MainPoint, Height, Width);
            Face.SetAttributes();
            SetPoints();
            SetSurface();
            SetVolume();
        }

        /// <summary>
        /// find volume of shape
        /// </summary>
        protected new void SetVolume()
        {
            Volume = Face.GetArea()*Depth;
        }

        /// <summary>
        /// find surface area of shape
        /// </summary>
        protected new void SetSurface()
        {
            Surface = Face.GetArea()*6;
        }

    }
}
