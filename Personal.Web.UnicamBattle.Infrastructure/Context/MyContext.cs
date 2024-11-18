using Microsoft.EntityFrameworkCore;

using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Infrastructure.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{
		}

		public virtual DbSet<Personaggio> Personaggi { get; set; }
		public virtual DbSet<Mossa> Mosse { get; set; }
		public virtual DbSet<PersonaggioMossa> PersonaggiMosse { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Carica le configurazioni dalle classi in questo progetto che implementano IEntityTypeConfiguration

			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}