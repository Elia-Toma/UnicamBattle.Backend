using Personal.Web.UnicamBattle.Infrastructure.Context;

namespace Personal.Web.UnicamBattle.Infrastructure.Repositories
{
	public abstract class BaseRepository
	{
		protected MyContext _ctx;
		protected BaseRepository(MyContext ctx)
		{
			_ctx = ctx;
		}
	}
}