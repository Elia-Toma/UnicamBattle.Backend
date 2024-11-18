using Microsoft.AspNetCore.Mvc;
using Personal.Web.UnicamBattle.Application.Abstractions.Services;
using Personal.Web.UnicamBattle.Application.Models.Dtos;
using Personal.Web.UnicamBattle.Application.Models.Responses;

namespace Personal.Web.UnicamBattle.API.Controllers
{
	[ApiController]
	[Route("api/v1.0/[controller]")]
	public class MosseController : BaseController
	{
		private readonly IMossaService _mosseService;

		public MosseController(IMossaService mosseService)
		{
			_mosseService = mosseService;
		}

		#region Create

		#endregion

		#region Read

		[HttpGet]
		[Route("personaggio/{idPersonaggio:int}")]
		public async Task<IActionResult> GetByIdPersonaggioAsync(int idPersonaggio)
		{
			try
			{
				var mosse = await _mosseService.GetByIdPersonaggioAsync(idPersonaggio);

				var response = new MultipleItemsResponse<MossaDto>
				{
					Result = mosse.Select(x => new MossaDto(x)).ToList()
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