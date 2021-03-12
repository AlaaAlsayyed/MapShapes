using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class TriangleRepository : GenericRepository<Triangle>, ITriangleRepository
    {
        public TriangleRepository(MapTaskContext context)
          : base(context)
        {
        }
    }
}
