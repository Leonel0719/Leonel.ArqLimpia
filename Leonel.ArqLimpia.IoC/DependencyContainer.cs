using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leonel.ArqLimpia.DAL;
using Leonel.ArqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Leonel.ArqLimpia.IoC
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddLeonelDependecies(this IServiceCollection services, IConfiguration configuration) 
		{
			services.AddDALDependecies(configuration);
			services.AddBLDependencies();
			return services;
		}
	}
}
