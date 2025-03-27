namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
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
		[EndpointName("userexperience")]
		[EndpointSummary("this is summary of create a new userexperience")]
		[EndpointDescription("this is description of create a new userexperience")]
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
		[EndpointName("updateuserexperience")]
		[EndpointSummary("you can use for update userexperience ability API")]
		[EndpointDescription("you can use for update userexperience ability API")]
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
        [EndpointName("deleteuserexperience")]
        [EndpointSummary("you can delete userexperience using this API")]
        [EndpointDescription("you can delete userexperience using this API")]
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
        [EndpointName("getuserexperience")]
        [EndpointSummary("you can use get data from userexperience API")]
        [EndpointDescription("you can use get data from userexperience API")]
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
        [EndpointName("getuserexperiencesingle")]
        [EndpointSummary("you can use get single data from userexperiencesingle API")]
        [EndpointDescription("you can use get single data from userexperiencesingle API")]
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