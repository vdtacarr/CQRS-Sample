using API.CQRS.Sample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Data
{
    public class MyWorldDbContext : DbContext
    {
		public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
		{ 
		}

		public DbSet<Products> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Products>(build => {
				build.HasKey(_ => _.ProductId);
			});
		}
	}
}
