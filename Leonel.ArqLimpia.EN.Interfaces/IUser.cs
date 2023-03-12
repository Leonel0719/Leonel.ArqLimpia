using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leonel.ArqLimpia.EN;

namespace Leonel.ArqLimpia.EN.Interfaces
{
	internal interface IUser
	{
		void Create(User PUser);
		void Update(User PUser);
		void Delete(User PUser);
		Task<User> GetById(User PUser);
		Task<List<User>> Search(User PUser);
	}
}
