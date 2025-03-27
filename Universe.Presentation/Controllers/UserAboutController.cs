namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserAboutController : ControllerBase
	{
		readonly IUserAboutService Service;
		public UserAboutController(IUserAboutService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userabout")]
        [Produces(typeof(Response<UserAboutResponse>))]
		[EndpointName("userabout")]
		[EndpointSummary("this is summary of create a new userabout")]
		[EndpointDescription("this is description of create a new userabout")]
		public async Task<Response<UserAboutResponse>> Create([FromBody] UserAboutRegisterDto Model)
		{
			Response<UserAboutResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userabout")]
		[Produces(typeof(Response<UserAboutResponse>))]
		[EndpointName("updateuserabout")]
		[EndpointSummary("you can use for update using userabout API")]
		[EndpointDescription("you can use for update using userabout API")]
		public async Task<Response<UserAboutResponse>> Update([FromBody] UserAboutUpdateDto Model)
		{
			Response<UserAboutResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userabout")]
		public async Task<Response<UserAboutResponse>> Delete([FromBody] UserAboutDeleteDto Model)
		{
			Response<UserAboutResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userabout")]
        [Produces(typeof(Response<UserAboutResponse>))]
        [EndpointName("getuserabout")]
        [EndpointSummary("you can use get data from userabout API")]
        [EndpointDescription("you can use get data from userabout API")]
        public async Task<Response<UserAboutResponse>> Get([FromQuery] UserAboutSelectDto Model)
		{
			Response<UserAboutResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserAboutResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/useraboutsingle")]
        [Produces(typeof(Response<UserAboutResponse>))]
        [EndpointName("getuseraboutsingle")]
        [EndpointSummary("you can use get single data from useraboutsingle API")]
        [EndpointDescription("you can use get single data from useraboutsingle API")]
        public async Task<Response<UserAboutResponse>> GetSingle([FromQuery] UserAboutSelectDto Model)
		{
			Response<UserAboutResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserAboutResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}