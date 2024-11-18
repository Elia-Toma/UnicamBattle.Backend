namespace Personal.Web.UnicamBattle.Domain
{
	public class Mossa
	{
		public int IdMossa { get; set; }       // Chiave primaria
		public string Nome { get; set; }      // Nome della mossa
		public string Descrizione { get; set; } // Descrizione della mossa
		public int Danno { get; set; }        // Valore di danno inflitto dalla mossa

		// Relazione con i personaggi che possono usare questa mossa
		public virtual ICollection<PersonaggioMossa> Personaggi { get; set; }
	}
}