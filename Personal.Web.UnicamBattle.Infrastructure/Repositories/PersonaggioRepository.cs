using Microsoft.EntityFrameworkCore;
using Personal.Web.UnicamBattle.Domain;
using Personal.Web.UnicamBattle.Domain.Abstractions.Repositories;
using Personal.Web.UnicamBattle.Infrastructure.Context;

namespace Personal.Web.UnicamBattle.Infrastructure.Repositories
{
	public class PersonaggioRepository : BaseRepository, IPersonaggioRepository
	{
		public PersonaggioRepository(MyContext ctx) : base(ctx)
		{
		}

		#region Create

		#endregion

		#region Read

		public async Task<IEnumerable<Personaggio>> GetAllAsync()
		{
			return await _ctx.Personaggi
				.AsNoTracking()
				.ToListAsync();
		}

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}