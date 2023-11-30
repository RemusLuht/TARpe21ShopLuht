using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopLuht.Core.Domain;

namespace TARpe21ShopLuht.Data
{
    public class TARpe21ShopLuhtContext : DbContext
    {
        public TARpe21ShopLuhtContext(DbContextOptions<TARpe21ShopLuhtContext> options) : base(options) { }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToApi> FilesToApi { get; set; }
    }
}
