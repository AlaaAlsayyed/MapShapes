using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Rectangle
    {
        public int Id { get; set; }
        public decimal StartPointX { get; set; }
        public decimal StartPointY { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int? RegionShapeId { get; set; }

        public virtual RegionShape RegionShape { get; set; }
    }
}
