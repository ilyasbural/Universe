namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserReferanceController : ControllerBase
	{
		readonly IUserReferanceService Service;
		public UserReferanceController(IUserReferanceService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userreferance")]
        [Produces(typeof(Response<UserReferanceResponse>))]
        [EndpointName("userreferance")]
		[EndpointSummary("this is summary of create a new userreferance")]
		[EndpointDescription("this is description of create a new userreferance")]
		public async Task<Response<UserReferanceResponse>> Create([FromBody] UserReferanceRegisterDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userreferance")]
		[Produces(typeof(Response<UserReferanceResponse>))]
		[EndpointName("updateuserreferance")]
		[EndpointSummary("you can use for update using userreferance API")]
		[EndpointDescription("you can use for update using userreferance API")]
		public async Task<Response<UserReferanceResponse>> Update([FromBody] UserReferanceUpdateDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userreferance")]
        [Produces(typeof(Response<UserReferanceResponse>))]
        [EndpointName("deleteuserreferance")]
        [EndpointSummary("you can delete userreferance using this API")]
        [EndpointDescription("you can delete userreferance using this API")]
        public async Task<Response<UserReferanceResponse>> Delete([FromBody] UserReferanceDeleteDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userreferance")]
        [Produces(typeof(Response<UserReferanceResponse>))]
        [EndpointName("getuserreferance")]
        [EndpointSummary("you can use get data from userreferance API")]
        [EndpointDescription("you can use get data from userreferance API")]
        public async Task<Response<UserReferanceResponse>> Get([FromQuery] UserReferanceSelectDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userreferancesingle")]
        [Produces(typeof(Response<UserReferanceResponse>))]
        [EndpointName("getuserreferancesingle")]
        [EndpointSummary("you can use get single data from userreferance API")]
        [EndpointDescription("you can use get single data from userreferance API")]
        public async Task<Response<UserReferanceResponse>> GetSingle([FromQuery] UserReferanceSelectDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}