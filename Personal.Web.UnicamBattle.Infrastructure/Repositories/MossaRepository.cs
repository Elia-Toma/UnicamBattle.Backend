using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal.Web.UnicamBattle.Domain;
using Personal.Web.UnicamBattle.Domain.Abstractions.Repositories;
using Personal.Web.UnicamBattle.Infrastructure.Context;

namespace Personal.Web.UnicamBattle.Infrastructure.Repositories
{
	public class MossaRepository : BaseRepository, IMossaRepository
	{
		public MossaRepository(MyContext context) : base(context)
		{
		}

		#region Create

		#endregion

		#region Read

		public async Task<IEnumerable<Mossa>> GetByIdPersonaggioAsync(int idPersonaggio)
		{
			// Il database gestisce direttamente il filtro con una sola query, sfruttando gli indici se configurati correttamente
			return await _ctx.Mosse
				.AsNoTracking()
				.Where(m => _ctx.PersonaggiMosse
					.Any(pm => pm.IdMossa == m.IdMossa && pm.IdPersonaggio == idPersonaggio))
				.ToListAsync();
		}

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}