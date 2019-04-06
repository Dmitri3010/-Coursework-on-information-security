using Coursework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework.Db
{
    public class EfContext:DbContext
    {
        public static string ConnectionString { private get; set; }

        public DbSet<User> users { get; set; }
        public DbSet<Message> messages { get; set; }

        public EfContext(DbContextOptions<EfContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
