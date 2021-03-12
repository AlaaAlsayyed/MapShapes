using Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRegionShapeRepository RegionShapes { get; }
        ICircleRepository Circles { get; }
        ILineRepository Lines { get; }
        ITriangleRepository Triangles { get; }
        IRectangleRepository Rectangles { get; }
        IPolygonRepository Polygons { get; }

        int SaveAllChanges();
    }
}
