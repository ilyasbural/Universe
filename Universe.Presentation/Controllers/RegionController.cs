namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
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
        [Produces(typeof(Response<RegionResponse>))]
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
        [Produces(typeof(Response<RegionResponse>))]
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