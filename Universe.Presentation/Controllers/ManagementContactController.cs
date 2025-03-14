﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagementContactController : ControllerBase
	{
		readonly IManagementContactService Service;
		public ManagementContactController(IManagementContactService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/managementcontact")]
		public async Task<Response<ManagementContactResponse>> Create([FromBody] ManagementContactRegisterDto Model)
		{
			Response<ManagementContactResponse> Response = await Service.InsertAsync(Model);
			return new Response<ManagementContactResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/managementcontact")]
		public async Task<Response<ManagementContactResponse>> Update([FromBody] ManagementContactUpdateDto Model)
		{
			Response<ManagementContactResponse> Response = await Service.UpdateAsync(Model);
			return new Response<ManagementContactResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/managementcontact")]
		public async Task<Response<ManagementContactResponse>> Delete([FromBody] ManagementContactDeleteDto Model)
		{
			Response<ManagementContactResponse> Response = await Service.DeleteAsync(Model);
			return new Response<ManagementContactResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/managementcontact")]
		public async Task<Response<ManagementContactResponse>> Get([FromQuery] ManagementContactSelectDto Model)
		{
			Response<ManagementContactResponse> Response = await Service.SelectAsync(Model);
			return new Response<ManagementContactResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/managementcontactsingle")]
		public async Task<Response<ManagementContactResponse>> GetSingle([FromQuery] ManagementContactSelectDto Model)
		{
			Response<ManagementContactResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<ManagementContactResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}