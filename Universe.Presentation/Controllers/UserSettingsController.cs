namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserSettingsController : ControllerBase
	{
		readonly IUserSettingsService Service;
		public UserSettingsController(IUserSettingsService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/usersettings")]
        [Produces(typeof(Response<UserSettingsResponse>))]
		public async Task<Response<UserSettingsResponse>> Create([FromBody] UserSettingsRegisterDto Model)
		{
			Response<UserSettingsResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usersettings")]
		[Produces(typeof(Response<UserSettingsResponse>))]
		public async Task<Response<UserSettingsResponse>> Update([FromBody] UserSettingsUpdateDto Model)
		{
			Response<UserSettingsResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usersettings")]
        [Produces(typeof(Response<UserSettingsResponse>))]
        public async Task<Response<UserSettingsResponse>> Delete([FromBody] UserSettingsDeleteDto Model)
		{
			Response<UserSettingsResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserSettingsResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usersettings")]
        [Produces(typeof(Response<UserSettingsResponse>))]
        public async Task<Response<UserSettingsResponse>> Get([FromQuery] UserSettingsSelectDto Model)
		{
			Response<UserSettingsResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserSettingsResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usersettingssingle")]
        [Produces(typeof(Response<UserSettingsResponse>))]
        public async Task<Response<UserSettingsResponse>> GetSingle([FromQuery] UserSettingsSelectDto Model)
		{
			Response<UserSettingsResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserSettingsResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}