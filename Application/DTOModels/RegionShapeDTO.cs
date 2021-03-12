using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOModels
{
    public class RegionShapeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CircleDTO> Circles { get; private set; }
        public ICollection<LineDTO> Lines { get; private set; }
        public ICollection<PolygonDTO> Polygons { get; private set; }
        public ICollection<RectangleDTO> Rectangles { get; private set; }
        public ICollection<TriangleDTO> Triangles { get; private set; }
  
    }
}
