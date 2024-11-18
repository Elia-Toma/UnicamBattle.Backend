using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Infrastructure.Configurations
{
	public class PersonaggioMossaConfiguration : IEntityTypeConfiguration<PersonaggioMossa>
	{
		public void Configure(EntityTypeBuilder<PersonaggioMossa> builder)
		{
			builder.ToTable("PersonaggiMosse");
			builder.HasKey(pm => new { pm.IdPersonaggio, pm.IdMossa });
			builder.HasOne(pm => pm.Personaggio)
				.WithMany(p => p.Mosse)
				.HasForeignKey(pm => pm.IdPersonaggio);
			builder.HasOne(pm => pm.Mossa)
				.WithMany(m => m.Personaggi)
				.HasForeignKey(pm => pm.IdMossa);
		}
	}
}