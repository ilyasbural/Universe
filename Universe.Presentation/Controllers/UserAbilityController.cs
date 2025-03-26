﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserAbilityController : ControllerBase
	{
		readonly IUserAbilityService Service;
		public UserAbilityController(IUserAbilityService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userability")]
        [Produces(typeof(Response<UserAbilityResponse>))]
		[EndpointName("userability")]
		[EndpointSummary("this is summary of create a new userability")]
		[EndpointDescription("this is description of create a new userability")]
		public async Task<Response<UserAbilityResponse>> Create([FromBody] UserAbilityRegisterDto Model)
		{
			Response<UserAbilityResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserAbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userability")]
		public async Task<Response<UserAbilityResponse>> Update([FromBody] UserAbilityUpdateDto Model)
		{
			Response<UserAbilityResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserAbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userability")]
		public async Task<Response<UserAbilityResponse>> Delete([FromBody] UserAbilityDeleteDto Model)
		{
			Response<UserAbilityResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserAbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userability")]
		public async Task<Response<UserAbilityResponse>> Get([FromQuery] UserAbilitySelectDto Model)
		{
			Response<UserAbilityResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserAbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userabilitysingle")]
		public async Task<Response<UserAbilityResponse>> GetSingle([FromQuery] UserAbilitySelectDto Model)
		{
			Response<UserAbilityResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserAbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}