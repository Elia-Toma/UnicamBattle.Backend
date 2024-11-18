using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Application.Abstractions.Services
{
	public interface IPersonaggioService
	{
		#region Create

		#endregion

		#region Read

		Task<IEnumerable<Personaggio>> GetAllAsync();

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}