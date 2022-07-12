using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IspitPIS.Models;

namespace IspitPIS.Data
{
    public class IspitPISContext : DbContext
    {
        public IspitPISContext (DbContextOptions<IspitPISContext> options)
            : base(options)
        {
        }

        public DbSet<IspitPIS.Models.Person>? Person { get; set; }
    }
}
