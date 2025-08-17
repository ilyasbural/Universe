namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserCountryController : ControllerBase
	{
		readonly IUserCountryService Service;
		public UserCountryController(IUserCountryService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/usercountry")]
        [Produces(typeof(Response<UserCountryResponse>))]
		public async Task<Response<UserCountryResponse>> Create([FromBody] UserCountryRegisterDto Model)
		{
			Response<UserCountryResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserCountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usercountry")]
		[Produces(typeof(Response<UserCountryResponse>))]
		public async Task<Response<UserCountryResponse>> Update([FromBody] UserCountryUpdateDto Model)
		{
			Response<UserCountryResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserCountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usercountry")]
        [Produces(typeof(Response<UserCountryResponse>))]
        public async Task<Response<UserCountryResponse>> Delete([FromBody] UserCountryDeleteDto Model)
		{
			Response<UserCountryResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserCountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usercountry")]
        [Produces(typeof(Response<UserCountryResponse>))]
        public async Task<Response<UserCountryResponse>> Get([FromQuery] UserCountrySelectDto Model)
		{
			Response<UserCountryResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserCountryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usercountrysingle")]
        [Produces(typeof(Response<UserCountryResponse>))]
        public async Task<Response<UserCountryResponse>> GetSingle([FromQuery] UserCountrySelectDto Model)
		{
			Response<UserCountryResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserCountryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}