using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Circle
    {
        public int Id { get; set; }
        public decimal Radius { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }

        // Foreign key to class region
        public int? RegionShapeId { get; set; }

        public virtual RegionShape RegionShape { get; set; }
    }
}
