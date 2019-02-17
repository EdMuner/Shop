

namespace Shop.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
   

    public class DataContext : IdentityDbContext<User>
    {


        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }

}
