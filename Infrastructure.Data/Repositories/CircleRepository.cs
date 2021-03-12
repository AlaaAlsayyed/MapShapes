using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class CircleRepository : GenericRepository<Circle>, ICircleRepository
    {
        public CircleRepository(MapTaskContext context)
          : base(context)
        {
        }
    }
}
