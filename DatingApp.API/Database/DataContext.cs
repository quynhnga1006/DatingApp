using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.DatingApp.API.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Namespace
{
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options) { }
            public DbSet<User> users {get; set;}
            
        }
    
    
        
    
}