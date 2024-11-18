namespace Personal.Web.UnicamBattle.Application.Models.Responses
{
	/// <summary>
	/// Represents a response containing a single item.
	/// </summary>
	/// <typeparam name="T">The type of the item.</typeparam>
	public class SingleItemResponse<T>
	{
		public bool Success { get; set; } = true;
		public T? Result { get; set; }
	}
}