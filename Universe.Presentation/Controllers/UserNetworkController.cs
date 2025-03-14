﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserNetworkController : ControllerBase
	{
		readonly IUserNetworkService Service;
		public UserNetworkController(IUserNetworkService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/usernetwork")]
		public async Task<Response<UserNetworkResponse>> Create([FromBody] UserNetworkRegisterDto Model)
		{
			Response<UserNetworkResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserNetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usernetwork")]
		public async Task<Response<UserNetworkResponse>> Update([FromBody] UserNetworkUpdateDto Model)
		{
			Response<UserNetworkResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserNetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usernetwork")]
		public async Task<Response<UserNetworkResponse>> Delete([FromBody] UserNetworkDeleteDto Model)
		{
			Response<UserNetworkResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserNetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usernetwork")]
		public async Task<Response<UserNetworkResponse>> Get([FromQuery] UserNetworkSelectDto Model)
		{
			Response<UserNetworkResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserNetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usernetworksingle")]
		public async Task<Response<UserNetworkResponse>> GetSingle([FromQuery] UserNetworkSelectDto Model)
		{
			Response<UserNetworkResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserNetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}