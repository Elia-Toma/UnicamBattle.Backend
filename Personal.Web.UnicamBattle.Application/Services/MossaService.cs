using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Web.UnicamBattle.Application.Abstractions.Services;
using Personal.Web.UnicamBattle.Domain;
using Personal.Web.UnicamBattle.Domain.Abstractions.Repositories;

namespace Personal.Web.UnicamBattle.Application.Services
{
	public class MossaService : IMossaService
	{
		private readonly IMossaRepository _mosseRepository;

		public MossaService(IMossaRepository mosseRepository)
		{
			_mosseRepository = mosseRepository;
		}

		#region Create

		#endregion

		#region Read

		public async Task<IEnumerable<Mossa>> GetByIdPersonaggioAsync(int idPersonaggio)
		{
			return await _mosseRepository.GetByIdPersonaggioAsync(idPersonaggio);
		}

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}