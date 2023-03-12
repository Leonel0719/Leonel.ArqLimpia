using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leonel.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace Leonel.ArqLimpia.DAL
{
	public class LeonelDbContext : DbContext
	{
		public LeonelDbContext(DbContextOptions<LeonelDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }
	}
}
