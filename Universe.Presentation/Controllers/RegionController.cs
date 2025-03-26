namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class RegionController : ControllerBase
	{
		readonly IRegionService Service;
		public RegionController(IRegionService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/region")]
        [Produces(typeof(Response<RegionResponse>))]
		[EndpointName("region")]
		[EndpointSummary("this is summary of create a new region")]
		[EndpointDescription("this is description of create a new region")]
		public async Task<Response<RegionResponse>> Create([FromBody] RegionRegisterDto Model)
		{
			Response<RegionResponse> Response = await Service.InsertAsync(Model);
			return new Response<RegionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/region")]
		[Produces(typeof(Response<RegionResponse>))]
		[EndpointName("updateregion")]
		[EndpointSummary("you can use for update using region API")]
		[EndpointDescription("you can use for update using region API")]
		public async Task<Response<RegionResponse>> Update([FromBody] RegionUpdateDto Model)
		{
			Response<RegionResponse> Response = await Service.UpdateAsync(Model);
			return new Response<RegionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/region")]
		public async Task<Response<RegionResponse>> Delete([FromBody] RegionDeleteDto Model)
		{
			Response<RegionResponse> Response = await Service.DeleteAsync(Model);
			return new Response<RegionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/region")]
        [Produces(typeof(Response<RegionResponse>))]
        [EndpointName("getregion")]
        [EndpointSummary("you can use get data from region API")]
        [EndpointDescription("you can use get data from region API")]
        public async Task<Response<RegionResponse>> Get([FromQuery] RegionSelectDto Model)
		{
			Response<RegionResponse> Response = await Service.SelectAsync(Model);
			return new Response<RegionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/regionsingle")]
		public async Task<Response<RegionResponse>> GetSingle([FromQuery] RegionSelectDto Model)
		{
			Response<RegionResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<RegionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}