namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class AnnounceController : ControllerBase
	{
		readonly IAnnounceService Service;
		public AnnounceController(IAnnounceService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/announce")]
		[Produces(typeof(Response<AnnounceResponse>))]
		[EndpointName("createannounce")]
		[EndpointSummary("you can create announce using this API")]
		[EndpointDescription("you can create announce using this API")]
		public async Task<Response<AnnounceResponse>> Create([FromBody] AnnounceRegisterDto Model)
		{
			Response<AnnounceResponse> Response = await Service.InsertAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/announce")]
		[Produces(typeof(Response<AbilityResponse>))]
		[EndpointName("updateannounce")]
		[EndpointSummary("you can use for update using announce API")]
		[EndpointDescription("you can use for update using announce API")]
		public async Task<Response<AnnounceResponse>> Update([FromBody] AnnounceUpdateDto Model)
		{
			Response<AnnounceResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/announce")]
        [Produces(typeof(Response<AnnounceResponse>))]
        //[EndpointName("deleteannounce")]
        [EndpointSummary("this is summary of create a new announce")]
        [EndpointDescription("this is description of create a new announce")]
        public async Task<Response<AnnounceResponse>> Delete([FromBody] AnnounceDeleteDto Model)
		{
			Response<AnnounceResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/announce")]
        [Produces(typeof(Response<AnnounceResponse>))]
        //[EndpointName("getannounce")]
        [EndpointSummary("you can use get data from announce API")]
        [EndpointDescription("you can use get data from announce API")]
        public async Task<Response<AnnounceResponse>> Get([FromQuery] AnnounceSelectDto Model)
		{
			Response<AnnounceResponse> Response = await Service.SelectAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/announcesingle")]
        [Produces(typeof(Response<AnnounceResponse>))]
        //[EndpointName("getannouncesingle")]
        [EndpointSummary("you can use get single data from announce API")]
        [EndpointDescription("you can use get single data from announce API")]
        public async Task<Response<AnnounceResponse>> GetSingle([FromQuery] AnnounceSelectDto Model)
		{
			Response<AnnounceResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}