using Personal.Web.UnicamBattle.Application.Abstractions.Services;
using Personal.Web.UnicamBattle.Domain;
using Personal.Web.UnicamBattle.Domain.Abstractions.Repositories;

namespace Personal.Web.UnicamBattle.Application.Services
{
	public class PersonaggioService : IPersonaggioService
	{
		private readonly IPersonaggioRepository _personaggioRepository;

		public PersonaggioService(IPersonaggioRepository personaggioRepository)
		{
			_personaggioRepository = personaggioRepository;
		}

		#region Create

		#endregion

		#region Read

		public async Task<IEnumerable<Personaggio>> GetAllAsync()
		{
			return await _personaggioRepository.GetAllAsync();
		}

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}