using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tamima.Models;

namespace Tamima.Data
{
    public class TamimaContext : DbContext
    {
        public TamimaContext (DbContextOptions<TamimaContext> options)
            : base(options)
        {
        }

        public DbSet<Tamima.Models.User> User { get; set; } = default!;
    }
}
