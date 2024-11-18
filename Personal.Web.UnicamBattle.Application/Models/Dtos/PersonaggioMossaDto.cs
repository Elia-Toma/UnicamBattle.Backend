using System.Text.Json.Serialization;
using Personal.Web.UnicamBattle.Domain;

namespace Personal.Web.UnicamBattle.Application.Models.Dtos
{
	public class PersonaggioMossaDto
	{
		public PersonaggioMossaDto()
		{
		}

		public PersonaggioMossaDto(PersonaggioMossa personaggioMossa)
		{
			IdPersonaggio = personaggioMossa.IdPersonaggio;
			Personaggio = new PersonaggioDto(personaggioMossa.Personaggio);
			IdMossa = personaggioMossa.IdMossa;
			Mossa = new MossaDto(personaggioMossa.Mossa);
		}

		public int IdPersonaggio { get; set; }

		[JsonIgnore]
		public virtual PersonaggioDto Personaggio { get; set; }
		public int IdMossa { get; set; }

		[JsonIgnore]
		public virtual MossaDto Mossa { get; set; }
	}
}