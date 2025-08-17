namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserEducationController : ControllerBase
	{
		readonly IUserEducationService Service;
		public UserEducationController(IUserEducationService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/usereducation")]
        [Produces(typeof(Response<UserEducationResponse>))]
		public async Task<Response<UserEducationResponse>> Create([FromBody] UserEducationRegisterDto Model)
		{
			Response<UserEducationResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usereducation")]
		[Produces(typeof(Response<UserEducationResponse>))]
		public async Task<Response<UserEducationResponse>> Update([FromBody] UserEducationUpdateDto Model)
		{
			Response<UserEducationResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usereducation")]
        [Produces(typeof(Response<UserEducationResponse>))]
        public async Task<Response<UserEducationResponse>> Delete([FromBody] UserEducationDeleteDto Model)
		{
			Response<UserEducationResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usereducation")]
        [Produces(typeof(Response<UserEducationResponse>))]
        public async Task<Response<UserEducationResponse>> Get([FromQuery] UserEducationSelectDto Model)
		{
			Response<UserEducationResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserEducationResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usereducationsingle")]
        [Produces(typeof(Response<UserEducationResponse>))]
        public async Task<Response<UserEducationResponse>> GetSingle([FromQuery] UserEducationSelectDto Model)
		{
			Response<UserEducationResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserEducationResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}