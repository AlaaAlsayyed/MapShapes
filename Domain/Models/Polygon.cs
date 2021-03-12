using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Polygon
    {
        public Polygon()
        {
            PolygonPoints = new HashSet<PolygonPoint>();
        }

        public int Id { get; set; }
        public int? RegionShapeId { get; set; }

        public virtual RegionShape RegionShape { get; set; }
        public virtual ICollection<PolygonPoint> PolygonPoints { get; private set; }
    }
}
