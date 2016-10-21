using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape3D : Shape
    {
        protected double? Volume;
        protected double? Surface;

        /// <summary>
        /// declear a 3d point to hold values for shapes including a printing override
        /// </summary>
        public struct Point3D
        {
            int X;
            int Y;
            int Z;

            public Point3D(int x, int y, int z = 0)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public override string ToString()
            {
                return "("+ X + ", " + Y + ", " + Z +")";
            }
        }
        protected List<Point3D> Points = new List<Point3D>();
        public Shape3D(Point mainPoint, int height,int width, int depth, string name, string type, string picture)
        {
            MainPoint = mainPoint;
            Name = name;
            Type = type;
            Picture = picture;
            Depth = depth;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// get the volume
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            SetVolume();
            return (double) (Volume ?? 0);
        }

        /// <summary>
        /// get the surface area
        /// </summary>
        /// <returns></returns>
        public double GetSurface()
        {
            SetSurface();
            return (double) (Surface ?? 0);
        }

        protected void SetVolume()
        {
        }

        protected void SetSurface()
        {
        }

        /// <summary>
        /// print out 3d objects
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var tempString = new StringBuilder();
            tempString.AppendLine("The shape type is" + Name);
            tempString.AppendLine("The main points are:");
            foreach (var point in Points)
            {
                tempString.AppendLine("point " + point);
            }
            tempString.AppendLine("The surface area is" + Surface);
            tempString.AppendLine("The Volume is" + Volume);
            return tempString.ToString();
        }
    }
}