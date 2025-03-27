namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserVideoController : ControllerBase
	{
		readonly IUserVideoService Service;
		public UserVideoController(IUserVideoService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/uservideo")]
        [Produces(typeof(Response<UserVideoResponse>))]
		[EndpointName("uservideo")]
		[EndpointSummary("this is summary of create a new uservideo")]
		[EndpointDescription("this is description of create a new uservideo")]
		public async Task<Response<UserVideoResponse>> Create([FromBody] UserVideoRegisterDto Model)
		{
			Response<UserVideoResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserVideoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/uservideo")]
		[Produces(typeof(Response<UserVideoResponse>))]
		[EndpointName("updateuservideo")]
		[EndpointSummary("you can use for update using uservideo API")]
		[EndpointDescription("you can use for update using uservideo API")]
		public async Task<Response<UserVideoResponse>> Update([FromBody] UserVideoUpdateDto Model)
		{
			Response<UserVideoResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserVideoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/uservideo")]
		public async Task<Response<UserVideoResponse>> Delete([FromBody] UserVideoDeleteDto Model)
		{
			Response<UserVideoResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserVideoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/uservideo")]
        [Produces(typeof(Response<UserVideoResponse>))]
        [EndpointName("getuservideo")]
        [EndpointSummary("you can use get data from uservideo API")]
        [EndpointDescription("you can use get data from uservideo API")]
        public async Task<Response<UserVideoResponse>> Get([FromQuery] UserVideoSelectDto Model)
		{
			Response<UserVideoResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserVideoResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/uservideosingle")]
        [Produces(typeof(Response<UserVideoResponse>))]
        [EndpointName("getuservideosingle")]
        [EndpointSummary("you can use get single data from uservideosingle API")]
        [EndpointDescription("you can use get single data from uservideosingle API")]
        public async Task<Response<UserVideoResponse>> GetSingle([FromQuery] UserVideoSelectDto Model)
		{
			Response<UserVideoResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserVideoResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}