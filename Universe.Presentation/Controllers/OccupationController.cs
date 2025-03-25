namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class OccupationController : ControllerBase
	{
		readonly IOccupationService Service;
		public OccupationController(IOccupationService service)
		{
			Service = service;
		}

		[Route("api/occupation")]
		[HttpPost("create")]
		[Produces(typeof(Response<OccupationResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new occupation")]
		[EndpointDescription("this is description of create a new occupation")]
		public async Task<Response<OccupationResponse>> Create([FromBody] OccupationRegisterDto Model)
		{
			Response<OccupationResponse> Response = await Service.InsertAsync(Model);
			return new Response<OccupationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/occupation")]
		public async Task<Response<OccupationResponse>> Update([FromBody] OccupationUpdateDto Model)
		{
			Response<OccupationResponse> Response = await Service.UpdateAsync(Model);
			return new Response<OccupationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/occupation")]
		public async Task<Response<OccupationResponse>> Delete([FromBody] OccupationDeleteDto Model)
		{
			Response<OccupationResponse> Response = await Service.DeleteAsync(Model);
			return new Response<OccupationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/occupation")]
		public async Task<Response<OccupationResponse>> Get([FromQuery] OccupationSelectDto Model)
		{
			Response<OccupationResponse> Response = await Service.SelectAsync(Model);
			return new Response<OccupationResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/occupationsingle")]
		public async Task<Response<OccupationResponse>> GetSingle([FromQuery] OccupationSelectDto Model)
		{
			Response<OccupationResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<OccupationResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}