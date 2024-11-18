namespace Personal.Web.UnicamBattle.Domain.Abstractions.Repositories
{
	public interface IPersonaggioRepository
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