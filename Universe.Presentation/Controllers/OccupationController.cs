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

		[HttpPost]
        [Route("api/occupation")]
        [Produces(typeof(Response<OccupationResponse>))]
		[EndpointName("occupation")]
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
		[Produces(typeof(Response<OccupationResponse>))]
		[EndpointName("updateoccupation")]
		[EndpointSummary("you can use for update using occupation API")]
		[EndpointDescription("you can use for update using occupation API")]
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
        [Produces(typeof(Response<OccupationResponse>))]
        [EndpointName("getoccupation")]
        [EndpointSummary("you can use get data from occupation API")]
        [EndpointDescription("you can use get data from occupation API")]
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
        [Produces(typeof(Response<OccupationResponse>))]
        [EndpointName("getsingleoccupation")]
        [EndpointSummary("you can use get data from occupation API")]
        [EndpointDescription("you can use get data from occupation API")]
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