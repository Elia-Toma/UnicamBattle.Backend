namespace Personal.Web.UnicamBattle.Application.Models.Responses
{
	/// <summary>
	/// Represents a response containing multiple items.
	/// </summary>
	/// <typeparam name="T">The type of the items.</typeparam>
	public class MultipleItemsResponse<T>
	{
		public bool Success { get; set; } = true;
		public List<T> Result { get; set; } = new List<T>();
	}
}