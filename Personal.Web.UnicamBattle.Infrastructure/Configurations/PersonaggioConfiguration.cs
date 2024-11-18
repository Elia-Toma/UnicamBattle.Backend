using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Infrastructure.Configurations
{
	public class PersonaggioConfiguration : IEntityTypeConfiguration<Personaggio>
	{
		public void Configure(EntityTypeBuilder<Personaggio> builder)
		{
			builder.ToTable("Personaggi");
			builder.HasKey(p => p.IdPersonaggio);
			builder.Property(p => p.Nome)
				.HasColumnType("varchar")
				.HasMaxLength(50)
				.IsRequired();
			builder.Property(p => p.Descrizione)
				.HasColumnType("varchar")
				.IsRequired();
			builder.Property(p => p.ImmagineUrl)
				.HasColumnType("varchar")
				.HasMaxLength(255);
			builder.Property(p => p.VitaBase)
				.HasColumnType("int")
				.IsRequired();
			builder.HasMany(p => p.Mosse);
		}
	}
}
