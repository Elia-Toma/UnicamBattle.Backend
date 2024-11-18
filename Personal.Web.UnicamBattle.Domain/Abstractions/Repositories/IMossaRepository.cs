using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Web.UnicamBattle.Domain.Abstractions.Repositories
{
	public interface IMossaRepository
	{
		#region Create

		#endregion

		#region Read

		Task<IEnumerable<Mossa>> GetByIdPersonaggioAsync(int idPersonaggio);

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}