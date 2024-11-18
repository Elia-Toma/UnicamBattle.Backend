using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Infrastructure.Configurations
{
	public class MossaConfiguration : IEntityTypeConfiguration<Mossa>
	{
		public void Configure(EntityTypeBuilder<Mossa> builder)
		{
			builder.ToTable("Mosse");
			builder.HasKey(m => m.IdMossa);
			builder.Property(m => m.Nome)
				.HasColumnType("varchar")
				.HasMaxLength(50)
				.IsRequired();
			builder.Property(m => m.Descrizione)
				.HasColumnType("varchar")
				.IsRequired();
			builder.Property(m => m.Danno)
				.HasColumnType("int")
				.IsRequired();
		}
	}
}