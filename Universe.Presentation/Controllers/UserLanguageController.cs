﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserLanguageController : ControllerBase
	{
		readonly IUserLanguageService Service;
		public UserLanguageController(IUserLanguageService service)
		{
			Service = service;
		}

		[Route("api/userlanguage")]
		[HttpPost("create")]
		[Produces(typeof(Response<UserLanguageResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new userlanguage")]
		[EndpointDescription("this is description of create a new userlanguage")]
		public async Task<Response<UserLanguageResponse>> Create([FromBody] UserLanguageRegisterDto Model)
		{
			Response<UserLanguageResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userlanguage")]
		public async Task<Response<UserLanguageResponse>> Update([FromBody] UserLanguageUpdateDto Model)
		{
			Response<UserLanguageResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userlanguage")]
		public async Task<Response<UserLanguageResponse>> Delete([FromBody] UserLanguageDeleteDto Model)
		{
			Response<UserLanguageResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userlanguage")]
		public async Task<Response<UserLanguageResponse>> Get([FromQuery] UserLanguageSelectDto Model)
		{
			Response<UserLanguageResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserLanguageResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userlanguagesingle")]
		public async Task<Response<UserLanguageResponse>> GetSingle([FromQuery] UserLanguageSelectDto Model)
		{
			Response<UserLanguageResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserLanguageResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}