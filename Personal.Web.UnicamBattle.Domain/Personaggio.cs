namespace Personal.Web.UnicamBattle.Domain
{
	public class Personaggio
	{
		public int IdPersonaggio { get; set; } // Chiave primaria
		public string Nome { get; set; }       // Nome del personaggio
		public string Descrizione { get; set; } // Descrizione del personaggio
		public string ImmagineUrl { get; set; } // URL dell'immagine
		public int VitaBase { get; set; }      // Punti vita base del personaggio

		// Relazione con le mosse (lista delle mosse associate a questo personaggio)
		public virtual ICollection<PersonaggioMossa> Mosse { get; set; }
	}
}