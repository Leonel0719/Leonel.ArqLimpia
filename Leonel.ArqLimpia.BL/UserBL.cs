using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leonel.ArqLimpia.BL.Interfaces;
using Leonel.ArqLimpia.EN;
using Leonel.ArqLimpia.EN.Interfaces;
using Leonel.ArqLimpia.BL.DTOs.UserDTOs;

namespace Leonel.ArqLimpia.BL
{
	public class UserBL : IUserBL
	{
		readonly IUser userDAL;
		readonly IUnitOfWork unitWork;
		public UserBL(IUser pUserDAL, IUnitOfWork pUnitWork)
		{
			userDAL = pUserDAL;
			unitWork = pUnitWork;
		}
		public async Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser)
		{
			User user = new User
			{
				Email = pUser.Email,
				Password = pUser.Password,
				Name = pUser.Name
			};
			userDAL.Create(user);
			await unitWork.SaveChangesAsync();
			CreateUserOutputDTO userOutput = new CreateUserOutputDTO
			{
				Id = user.Id,
				Email = user.Email,
				Name = user.Name
			};
			return userOutput;
		}

		public async Task<int> Borrar(DeleteUserDTO pUser)
		{
			User user = await userDAL.GetById(new User { Id = pUser.Id });
			if (user.Id == pUser.Id)
			{
				userDAL. Borrar(user);
				return await unitWork.SaveChangesAsync();
			}
			else
				return 0;
		}

		public async Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser)
		{
			User user = await userDAL.GetById(new User { Id = pUser.Id });
			return new GetByIdUserOutputDTO
			{
				Id = user.Id,
				Name = user.Name,
				Email = user.Email
			};
		}

		public async Task<List<SearchUserOutputDTO>> Buscar(SearchUserInputDTO pUser)
		{
			List<User> users = await userDAL.Buscar(new User { Email = pUser.Email, Name = pUser.Name });
			List<SearchUserOutputDTO> list = new List<SearchUserOutputDTO>();
			users.ForEach(s => list.Add(new SearchUserOutputDTO
			{
				Id = s.Id,
				Email = s.Email,
				Name = s.Name
			}));
			return list;
		}
		 
		public async Task<int> Actualizar(UpdateUserDTO pUser)
		{
			User user = await userDAL.GetById(new User { Id = pUser.Id });
			if (user.Id == pUser.Id)
			{
				user.Name = pUser.Name;
				userDAL.Actualizar(user);
				return await unitWork.SaveChangesAsync();
			}
			else
				return 0;
		}
	}
}
