using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Application.Abstractions.Services
{
	public interface IMossaService
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