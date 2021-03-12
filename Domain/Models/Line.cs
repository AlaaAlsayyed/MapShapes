using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Line
    {
        public int Id { get; set; }
        public decimal FirstPointX { get; set; }
        public decimal FirstPointY { get; set; }
        public decimal SecondPointX { get; set; }
        public decimal SecondPointY { get; set; }

        public int? RegionShapeId { get; set; }

        public virtual RegionShape RegionShape { get; set; }
    }
}
