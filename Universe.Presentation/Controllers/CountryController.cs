﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

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
		[Produces(typeof(Response<CountryResponse>))]
		[EndpointName("createcountry")]
		[EndpointSummary("this is summary of create a new country")]
		[EndpointDescription("this is description of create a new country")]
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
		[Produces(typeof(Response<CountryResponse>))]
		[EndpointName("updatecountry")]
		[EndpointSummary("you can use for update using country API")]
		[EndpointDescription("you can use for update using country API")]
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
        [Produces(typeof(Response<CountryResponse>))]
        [EndpointName("deletecountry")]
        [EndpointSummary("you can delete country using this API")]
        [EndpointDescription("you can delete country using this API")]
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
        [Produces(typeof(Response<CountryResponse>))]
        [EndpointName("getcountry")]
        [EndpointSummary("you can use get data from country API")]
        [EndpointDescription("you can use get data from country API")]
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
        [Produces(typeof(Response<CountryResponse>))]
        [EndpointName("getsinglecountry")]
        [EndpointSummary("you can use get single data from country API")]
        [EndpointDescription("you can use get single data from country API")]
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