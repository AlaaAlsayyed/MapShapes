using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public class RegionShape
    {
        public RegionShape()
        {
            Polygons = new HashSet<Polygon>();
            Rectangles = new HashSet<Rectangle>();
            Triangles = new HashSet<Triangle>();
            Circles = new HashSet<Circle>();
            Lines = new HashSet<Line>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Polygon> Polygons { get; private set; }
        public virtual ICollection<Rectangle> Rectangles { get; private set; }
        public virtual ICollection<Triangle> Triangles { get; private set; }
        public virtual ICollection<Circle> Circles { get; private set; }
        public virtual ICollection<Line> Lines { get; private set; }

    }
}
