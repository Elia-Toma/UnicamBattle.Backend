using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Application.Models.Dtos
{
	public class PersonaggioDto
	{
		public PersonaggioDto()
		{
		}

		public PersonaggioDto(Personaggio personaggio)
		{
			IdPersonaggio = personaggio.IdPersonaggio;
			Nome = personaggio.Nome;
			Descrizione = personaggio.Descrizione;
			ImmagineUrl = personaggio.ImmagineUrl;
			VitaBase = personaggio.VitaBase;

			Mosse = personaggio.Mosse;
		}

		public int IdPersonaggio { get; set; }
		public string Nome { get; set; }
		public string Descrizione { get; set; }
		public string ImmagineUrl { get; set; }
		public int VitaBase { get; set; }

		public virtual ICollection<PersonaggioMossa> Mosse { get; set; }
	}
}