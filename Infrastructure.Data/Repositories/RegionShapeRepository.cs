using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class RegionShapeRepository : GenericRepository<RegionShape>, IRegionShapeRepository
    {
        public RegionShapeRepository(MapTaskContext context)
          : base(context)
        {
        }
    }
}
