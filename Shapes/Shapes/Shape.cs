using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        protected string Name { get; set; }
        protected string Type { get; set; }
        public string Picture { get; set; }

        public Point MainPoint { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Radius { get; set; }

        public Shape()
        {
            Name = "";
            Type = "";
            Picture = "";
            MainPoint = new Point();
        }

        public override string ToString()
        {
            return "";
        }

        public virtual void SetAttributes()
        {

        }
    }
}
