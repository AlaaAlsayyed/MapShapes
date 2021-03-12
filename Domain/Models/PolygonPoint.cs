using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PolygonPoint
    {
        public int Id { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int? PolygonId { get; set; }

        public virtual Polygon Polygon { get; set; }
    }
}
