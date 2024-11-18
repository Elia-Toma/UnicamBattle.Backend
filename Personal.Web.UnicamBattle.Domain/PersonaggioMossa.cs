namespace Personal.Web.UnicamBattle.Domain
{
	public class PersonaggioMossa
	{
		public int IdPersonaggio { get; set; } // Chiave esterna verso Personaggio
		public virtual Personaggio Personaggio { get; set; } // Navigational property

		public int IdMossa { get; set; }       // Chiave esterna verso Mossa
		public virtual Mossa Mossa { get; set; }       // Navigational property
	}
}