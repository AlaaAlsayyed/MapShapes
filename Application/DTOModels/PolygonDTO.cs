using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOModels
{
    public class PolygonDTO
    {
        public int Id { get; set; }

        public ICollection<PolygonPointDTO> PolygonPoints { get; set; }
    }
}
