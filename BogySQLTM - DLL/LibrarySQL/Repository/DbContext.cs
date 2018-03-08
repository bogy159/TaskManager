using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Entity;
using LibrarySQL.Entiry;

namespace LibrarySQL.Repository
{
    public class BloggingContext : DbContext
        {
            public DbSet<Users> Users { get; set; }
            public DbSet<MTasks> MTasks { get; set; }
            public DbSet<TimeSpent> TimeSpent { get; set; }
        }
}
