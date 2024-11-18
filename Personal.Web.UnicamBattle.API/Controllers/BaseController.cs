using Microsoft.AspNetCore.Mvc;
using Personal.Web.UnicamBattle.Application.Models.Responses;

namespace Personal.Web.UnicamBattle.API.Controllers
{
	public class BaseController : Controller
	{
		protected IActionResult HandleException(Exception ex)
		{
			var errorResponse = new ErrorResponse
			{
				Errors = ex.Message
			};
			return BadRequest(errorResponse);
		}
	}
}