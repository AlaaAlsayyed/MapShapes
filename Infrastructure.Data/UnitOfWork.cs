using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private MapTaskContext _mapTaskContext;

        private IRegionShapeRepository _regionShapes;
        private ILineRepository _lines;
        private ITriangleRepository _triangles;
        private IRectangleRepository _rectangles;
        private ICircleRepository _circles;
        private IPolygonRepository _polygons;

        public UnitOfWork(MapTaskContext context)
        {
            _mapTaskContext = context;
        }

        public IRegionShapeRepository RegionShapes
        {
            get
            {
                if (_regionShapes == null)
                {
                    _regionShapes = new RegionShapeRepository(_mapTaskContext);
                }
                return _regionShapes;
            }
        }

        public ILineRepository Lines
        {
            get
            {
                if (_lines == null)
                {
                    _lines = new LineRepository(_mapTaskContext);
                }
                return _lines;
            }
        }

        public ITriangleRepository Triangles
        {
            get
            {
                if (_triangles == null)
                {
                    _triangles = new TriangleRepository(_mapTaskContext);
                }
                return _triangles;
            }
        }

        public IRectangleRepository Rectangles
        {
            get
            {
                if (_rectangles == null)
                {
                    _rectangles = new RectangleRepository(_mapTaskContext);
                }
                return _rectangles;
            }
        }

        public ICircleRepository Circles
        {
            get
            {
                if (_circles == null)
                {
                    _circles = new CircleRepository(_mapTaskContext);
                }
                return _circles;
            }
        }
      
        public IPolygonRepository Polygons
        {
            get
            {
                if (_polygons == null)
                {
                    _polygons = new PolygonRepository(_mapTaskContext);
                }
                return _polygons;
            }
        }

        public int SaveAllChanges()
        {
            return _mapTaskContext.SaveChanges();
        }

        public void Dispose()
        {
            _mapTaskContext.Dispose();
        }
    }
}
