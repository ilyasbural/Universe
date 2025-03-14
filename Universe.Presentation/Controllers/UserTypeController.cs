﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserTypeController : ControllerBase
	{
		readonly IUserTypeService Service;
		public UserTypeController(IUserTypeService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/usertype")]
		public async Task<Response<UserTypeResponse>> Create([FromBody] UserTypeRegisterDto Model)
		{
			Response<UserTypeResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserTypeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usertype")]
		public async Task<Response<UserTypeResponse>> Update([FromBody] UserTypeUpdateDto Model)
		{
			Response<UserTypeResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserTypeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usertype")]
		public async Task<Response<UserTypeResponse>> Delete([FromBody] UserTypeDeleteDto Model)
		{
			Response<UserTypeResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserTypeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usertype")]
		public async Task<Response<UserTypeResponse>> Get([FromQuery] UserTypeSelectDto Model)
		{
			Response<UserTypeResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserTypeResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usertypesingle")]
		public async Task<Response<UserTypeResponse>> GetSingle([FromQuery] UserTypeSelectDto Model)
		{
			Response<UserTypeResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserTypeResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}