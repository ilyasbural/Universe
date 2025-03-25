namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserController : ControllerBase
	{
		readonly IUserService Service;
		public UserController(IUserService service)
		{
			Service = service;
		}

		[Route("api/user")]
		[HttpPost("create")]
		[Produces(typeof(Response<UserResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new user")]
		[EndpointDescription("this is description of create a new user")]
		public async Task<Response<UserResponse>> Create([FromBody] UserRegisterDto Model)
		{
			Response<UserResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/user")]
		public async Task<Response<UserResponse>> Update([FromBody] UserUpdateDto Model)
		{
			Response<UserResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/user")]
		public async Task<Response<UserResponse>> Delete([FromBody] UserDeleteDto Model)
		{
			Response<UserResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/user")]
		public async Task<Response<UserResponse>> Get([FromQuery] UserSelectDto Model)
		{
			Response<UserResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usersingle")]
		public async Task<Response<UserResponse>> GetSingle([FromQuery] UserSelectDto Model)
		{
			Response<UserResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}