namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class CountryController : ControllerBase
	{
		readonly ICountryService Service;
		public CountryController(ICountryService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/country")]
		public async Task<Response<CountryResponse>> Create([FromBody] CountryRegisterDto Model)
		{
			Response<CountryResponse> Response = await Service.InsertAsync(Model);
			return new Response<CountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/country")]
		public async Task<Response<CountryResponse>> Update([FromBody] CountryUpdateDto Model)
		{
			Response<CountryResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/country")]
		public async Task<Response<CountryResponse>> Delete([FromBody] CountryDeleteDto Model)
		{
			Response<CountryResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CountryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/country")]
		public async Task<Response<CountryResponse>> Get([FromQuery] CountrySelectDto Model)
		{
			Response<CountryResponse> Response = await Service.SelectAsync(Model);
			return new Response<CountryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/countrysingle")]
		public async Task<Response<CountryResponse>> GetSingle([FromQuery] CountrySelectDto Model)
		{
			Response<CountryResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CountryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}