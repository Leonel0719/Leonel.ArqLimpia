using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Leonel.ArqLimpia.BL.Interfaces;

namespace Leonel.ArqLimpia.BL
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddBLDependencies(this IServiceCollection services)
		{
			services.AddTransient<IUserBL, UserBL>();
			return services;
		}
	}
}
