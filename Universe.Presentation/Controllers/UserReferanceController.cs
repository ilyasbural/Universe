﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserReferanceController : ControllerBase
	{
		readonly IUserReferanceService Service;
		public UserReferanceController(IUserReferanceService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/userreferance")]
		public async Task<Response<UserReferanceResponse>> Create([FromBody] UserReferanceRegisterDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userreferance")]
		public async Task<Response<UserReferanceResponse>> Update([FromBody] UserReferanceUpdateDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userreferance")]
		public async Task<Response<UserReferanceResponse>> Delete([FromBody] UserReferanceDeleteDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userreferance")]
		public async Task<Response<UserReferanceResponse>> Get([FromQuery] UserReferanceSelectDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userreferancesingle")]
		public async Task<Response<UserReferanceResponse>> GetSingle([FromQuery] UserReferanceSelectDto Model)
		{
			Response<UserReferanceResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserReferanceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}