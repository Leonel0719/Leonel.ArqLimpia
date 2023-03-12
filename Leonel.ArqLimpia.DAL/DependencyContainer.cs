using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Leonel.ArqLimpia.EN.Interfaces;

namespace Leonel.ArqLimpia.DAL
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration) 
		{
			services.AddDbContext<LeonelDbContext>(Options =>
			Options.UseSqlServer(configuration.GetConnectionString("conexion")));

			services.AddScoped<IUser, UserDAL>();
			services.AddScoped<IUnitiOfWork, UnitOfWork>();

			return services;
		}
	}
}
