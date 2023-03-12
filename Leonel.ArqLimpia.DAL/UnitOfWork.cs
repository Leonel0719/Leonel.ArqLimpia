using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leonel.ArqLimpia.EN.Interfaces;

namespace Leonel.ArqLimpia.DAL
{
	public class UnitOfWork : IUnitiOfWork
	{
		readonly LeonelDbContext dbContext;

		public UnitOfWork(LeonelDbContext pBbContext)
		{
			dbContext = pBbContext;
		}

		public Task<int> SaveChangesAsync()
		{
			return dbContext.SaveChangesAsync();
		}
	}
}
