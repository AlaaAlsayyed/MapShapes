using Application.DTOModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegionShapeDTO, RegionShape>().ReverseMap();
            CreateMap<RectangleDTO, Rectangle>().ReverseMap();
            CreateMap<TriangleDTO, Triangle>().ReverseMap();
            CreateMap<LineDTO, Line>().ReverseMap();
            CreateMap<PolygonDTO, Polygon>().ReverseMap();
            CreateMap<CircleDTO, Circle>().ReverseMap();
            CreateMap<PolygonPointDTO, PolygonPoint>().ReverseMap();

        }
    }
}
