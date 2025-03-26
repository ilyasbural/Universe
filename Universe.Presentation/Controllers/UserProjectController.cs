namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserProjectController : ControllerBase
	{
		readonly IUserProjectService Service;
		public UserProjectController(IUserProjectService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/userproject")]
        [Produces(typeof(Response<UserProjectResponse>))]
		[EndpointName("userproject")]
		[EndpointSummary("this is summary of create a new userproject")]
		[EndpointDescription("this is description of create a new userproject")]
		public async Task<Response<UserProjectResponse>> Create([FromBody] UserProjectRegisterDto Model)
		{
			Response<UserProjectResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserProjectResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userproject")]
		public async Task<Response<UserProjectResponse>> Update([FromBody] UserProjectUpdateDto Model)
		{
			Response<UserProjectResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserProjectResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userproject")]
		public async Task<Response<UserProjectResponse>> Delete([FromBody] UserProjectDeleteDto Model)
		{
			Response<UserProjectResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserProjectResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userproject")]
        [Produces(typeof(Response<UserProjectResponse>))]
        [EndpointName("getuserproject")]
        [EndpointSummary("you can use get data from userproject API")]
        [EndpointDescription("you can use get data from userproject API")]
        public async Task<Response<UserProjectResponse>> Get([FromQuery] UserProjectSelectDto Model)
		{
			Response<UserProjectResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserProjectResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userprojectsingle")]
		public async Task<Response<UserProjectResponse>> GetSingle([FromQuery] UserProjectSelectDto Model)
		{
			Response<UserProjectResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserProjectResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}