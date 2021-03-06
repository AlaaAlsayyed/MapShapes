using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class LineRepository: GenericRepository<Line>, ILineRepository
    {
        public LineRepository(MapTaskContext context) : base(context)
        {
        }
    }
}
