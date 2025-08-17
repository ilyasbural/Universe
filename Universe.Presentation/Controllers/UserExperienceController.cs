namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserExperienceController : ControllerBase
	{
		readonly IUserExperienceService Service;
		public UserExperienceController(IUserExperienceService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userexperience")]
        [Produces(typeof(Response<UserExperienceResponse>))]
		public async Task<Response<UserExperienceResponse>> Create([FromBody] UserExperienceRegisterDto Model)
		{
			Response<UserExperienceResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserExperienceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userexperience")]
		[Produces(typeof(Response<UserExperienceResponse>))]
		public async Task<Response<UserExperienceResponse>> Update([FromBody] UserExperienceUpdateDto Model)
		{
			Response<UserExperienceResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserExperienceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userexperience")]
        [Produces(typeof(Response<UserExperienceResponse>))]
        public async Task<Response<UserExperienceResponse>> Delete([FromBody] UserExperienceDeleteDto Model)
		{
			Response<UserExperienceResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserExperienceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userexperience")]
        [Produces(typeof(Response<UserExperienceResponse>))]
        public async Task<Response<UserExperienceResponse>> Get([FromQuery] UserExperienceSelectDto Model)
		{
			Response<UserExperienceResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserExperienceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userexperiencesingle")]
        [Produces(typeof(Response<UserExperienceResponse>))]
        public async Task<Response<UserExperienceResponse>> GetSingle([FromQuery] UserExperienceSelectDto Model)
		{
			Response<UserExperienceResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserExperienceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}