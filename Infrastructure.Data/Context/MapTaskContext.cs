using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Context
{
    public class MapTaskContext : DbContext
    {
        public MapTaskContext() { }

        public MapTaskContext(DbContextOptions<MapTaskContext> options) : base(options) { }

        public virtual DbSet<RegionShape> RegionShape { get; set; }
        public virtual DbSet<Circle> Circle { get; set; }
        public virtual DbSet<Line> Line { get; set; }
        public virtual DbSet<Polygon> Polygon { get; set; }
        public virtual DbSet<PolygonPoint> PolygonPoint { get; set; }
        public virtual DbSet<Rectangle> Rectangle { get; set; }
        public virtual DbSet<Triangle> Triangle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MapTask;Integrated Security=True;");
            }
        }     
    }
}
