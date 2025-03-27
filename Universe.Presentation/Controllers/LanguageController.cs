namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class LanguageController : ControllerBase
	{
		readonly ILanguageService Service;
		public LanguageController(ILanguageService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/language")]
        [Produces(typeof(Response<LanguageResponse>))]
		[EndpointName("language")]
		[EndpointSummary("this is summary of create a new language")]
		[EndpointDescription("this is description of create a new language")]
		public async Task<Response<LanguageResponse>> Create([FromBody] LanguageRegisterDto Model)
		{
			Response<LanguageResponse> Response = await Service.InsertAsync(Model);
			return new Response<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/language")]
		[Produces(typeof(Response<LanguageResponse>))]
		[EndpointName("updatelanguage")]
		[EndpointSummary("you can use for update using language API")]
		[EndpointDescription("you can use for update using language API")]
		public async Task<Response<LanguageResponse>> Update([FromBody] LanguageUpdateDto Model)
		{
			Response<LanguageResponse> Response = await Service.UpdateAsync(Model);
			return new Response<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/language")]
		public async Task<Response<LanguageResponse>> Delete([FromBody] LanguageDeleteDto Model)
		{
			Response<LanguageResponse> Response = await Service.DeleteAsync(Model);
			return new Response<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/language")]
        [Produces(typeof(Response<LanguageResponse>))]
        [EndpointName("getlanguage")]
        [EndpointSummary("you can use get data from language API")]
        [EndpointDescription("you can use get data from language API")]
        public async Task<Response<LanguageResponse>> Get([FromQuery] LanguageSelectDto Model)
		{
			Response<LanguageResponse> Response = await Service.SelectAsync(Model);
			return new Response<LanguageResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/languagesingle")]
        [Produces(typeof(Response<LanguageResponse>))]
        [EndpointName("getsinglelanguage")]
        [EndpointSummary("you can use get data from language API")]
        [EndpointDescription("you can use get data from language API")]
        public async Task<Response<LanguageResponse>> GetSingle([FromQuery] LanguageSelectDto Model)
		{
			Response<LanguageResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<LanguageResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}