﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class NetworkController : ControllerBase
	{
		readonly INetworkService Service;
		public NetworkController(INetworkService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/network")]
		public async Task<Response<NetworkResponse>> Create([FromBody] NetworkRegisterDto Model)
		{
			Response<NetworkResponse> Response = await Service.InsertAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/network")]
		public async Task<Response<NetworkResponse>> Update([FromBody] NetworkUpdateDto Model)
		{
			Response<NetworkResponse> Response = await Service.UpdateAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/network")]
		public async Task<Response<NetworkResponse>> Delete([FromBody] NetworkDeleteDto Model)
		{
			Response<NetworkResponse> Response = await Service.DeleteAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/network")]
		public async Task<Response<NetworkResponse>> Get([FromQuery] NetworkSelectDto Model)
		{
			Response<NetworkResponse> Response = await Service.SelectAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/networksingle")]
		public async Task<Response<NetworkResponse>> GetSingle([FromQuery] NetworkSelectDto Model)
		{
			Response<NetworkResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}