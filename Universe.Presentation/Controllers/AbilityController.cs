﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class AbilityController : ControllerBase
	{
		readonly IAbilityService Service;
		public AbilityController(IAbilityService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/ability")]
		public async Task<Response<AbilityResponse>> Create([FromBody] AbilityRegisterDto Model)
		{
			Response<AbilityResponse> Response = await Service.InsertAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/ability")]
		public async Task<Response<AbilityResponse>> Update([FromBody] AbilityUpdateDto Model)
		{
			Response<AbilityResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AbilityResponse>
			{
                ResponseData = Response.ResponseData
            };
		}

		[HttpDelete]
		[Route("api/ability")]
		public async Task<Response<AbilityResponse>> Delete([FromBody] AbilityDeleteDto Model)
		{
			Response<AbilityResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/ability")]
		public async Task<Response<AbilityResponse>> Get([FromQuery] AbilitySelectDto Model)
		{
			Response<AbilityResponse> Response = await Service.SelectAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/abilitysingle")]
		public async Task<Response<AbilityResponse>> GetSingle([FromQuery] AbilitySelectDto Model)
		{
			Response<AbilityResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}