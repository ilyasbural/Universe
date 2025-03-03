namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class PositionController : ControllerBase
	{
		readonly IPositionService Service;
		public PositionController(IPositionService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/position")]
		public async Task<Response<PositionResponse>> Create([FromBody] PositionRegisterDto Model)
		{
			Response<PositionResponse> Response = await Service.InsertAsync(Model);
			return new Response<PositionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/position")]
		public async Task<Response<PositionResponse>> Update([FromBody] PositionUpdateDto Model)
		{
			Response<PositionResponse> Response = await Service.UpdateAsync(Model);
			return new Response<PositionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/position")]
		public async Task<Response<PositionResponse>> Delete([FromBody] PositionDeleteDto Model)
		{
			Response<PositionResponse> Response = await Service.DeleteAsync(Model);
			return new Response<PositionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/position")]
		public async Task<Response<PositionResponse>> Get([FromQuery] PositionSelectDto Model)
		{
			Response<PositionResponse> Response = await Service.SelectAsync(Model);
			return new Response<PositionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/positionsingle")]
		public async Task<Response<PositionResponse>> GetSingle([FromQuery] PositionSelectDto Model)
		{
			Response<PositionResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<PositionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}