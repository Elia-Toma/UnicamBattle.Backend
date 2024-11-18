namespace Pcsnet.Web.Rapportini.Application.Options
{
	/// <summary>
	/// Represents the CORS options for the application.
	/// </summary>
	public class CorsOption
    {
		/// <summary>
		/// Gets or sets the list of allowed origins for CORS.
		/// </summary>
		public List<string> Origins { get; set; } = new List<string>();
    }
}