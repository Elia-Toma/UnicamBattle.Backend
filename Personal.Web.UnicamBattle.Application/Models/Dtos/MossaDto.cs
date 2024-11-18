using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Application.Models.Dtos
{
	public class MossaDto
	{
		public MossaDto()
		{
		}

		public MossaDto(Mossa mossa)
		{
			IdMossa = mossa.IdMossa;
			Nome = mossa.Nome;
			Descrizione = mossa.Descrizione;
			Danno = mossa.Danno;

			Personaggi = mossa.Personaggi;
		}

		public int IdMossa { get; set; }
		public string Nome { get; set; }
		public string Descrizione { get; set; }
		public int Danno { get; set; }

		public virtual ICollection<PersonaggioMossa> Personaggi { get; set; }
	}
}