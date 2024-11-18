using Microsoft.AspNetCore.Mvc;
using Personal.Web.UnicamBattle.Application.Abstractions.Services;
using Personal.Web.UnicamBattle.Application.Models.Dtos;
using Personal.Web.UnicamBattle.Application.Models.Responses;

namespace Personal.Web.UnicamBattle.API.Controllers
{
	[ApiController]
	[Route("api/v1.0/[controller]")]
	public class PersonaggiController : BaseController
	{
		private readonly IPersonaggioService _personaggioService;

		public PersonaggiController(IPersonaggioService personaggioService)
		{
			_personaggioService = personaggioService;
		}

		#region Create

		#endregion

		#region Read

		[HttpGet]
		[Route("all")]
		public async Task<IActionResult> GetAllAsync()
		{
			try
			{
				var personaggi = await _personaggioService.GetAllAsync();

				var response = new MultipleItemsResponse<PersonaggioDto>
				{
					Result = personaggi.Select(x => new PersonaggioDto(x)).ToList()
				};

				return Ok(response);
			}
			catch (Exception ex)
			{
				return HandleException(ex);
			}
		}

		#endregion

		#region Update

		#endregion

		#region Delete

		#endregion
	}
}