using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Leonel.ArqLimpia.BL.DTOs;
using Leonel.ArqLimpia.BL.DTOs.UserDTOs;

namespace Leonel.ArqLimpia.BL.Interfaces
{
	public interface IUserBL
	{
		Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser);
		Task<int> Actualizar(UpdateUserDTO pUser);
		Task<int> Eliminar(DeleteUserDTO pUser);
		Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser);
		Task<List<SearchUserOutputDTO>> Buscar(SearchUserInputDTO pUser);
	}
}
