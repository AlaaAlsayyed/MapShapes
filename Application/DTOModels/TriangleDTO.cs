using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOModels
{
    public class TriangleDTO
    {
        public int Id { get; set; }
        public decimal FirstPointX { get; set; }
        public decimal FirstPointY { get; set; }
        public decimal SecondPointX { get; set; }
        public decimal SecondPointY { get; set; }
        public decimal ThirdPointX { get; set; }
        public decimal ThirdPointY { get; set; }
    }
}
