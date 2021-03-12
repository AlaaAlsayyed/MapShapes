using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOModels
{
    public class RectangleDTO
    {
        public int Id { get; set; }
        public decimal StartPointX { get; set; }
        public decimal StartPointY { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
