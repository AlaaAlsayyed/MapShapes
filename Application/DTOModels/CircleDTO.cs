using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOModels
{
    public class CircleDTO
    {
        public int Id { get; set; }
        public float Radius { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }
    }
}
