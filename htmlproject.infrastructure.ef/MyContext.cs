using htmlproject.core.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace htmlproject.infrastructure.ef
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> dbContextOptions) : base(dbContextOptions)
        {

        }

       


        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reciept> Reciepts { get; set; }







    }
}
