﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class CompanyAboutController : ControllerBase
	{
		readonly ICompanyAboutService Service;
		public CompanyAboutController(ICompanyAboutService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/companyabout")]
		public async Task<Response<CompanyAboutResponse>> Create([FromBody] CompanyAboutRegisterDto Model)
		{
			Response<CompanyAboutResponse> Response = await Service.InsertAsync(Model);
			return new Response<CompanyAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/companyabout")]
		public async Task<Response<CompanyAboutResponse>> Update([FromBody] CompanyAboutUpdateDto Model)
		{
			Response<CompanyAboutResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CompanyAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/companyabout")]
		public async Task<Response<CompanyAboutResponse>> Delete([FromBody] CompanyAboutDeleteDto Model)
		{
			Response<CompanyAboutResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CompanyAboutResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/companyabout")]
		public async Task<Response<CompanyAboutResponse>> Get([FromQuery] CompanyAboutSelectDto Model)
		{
			Response<CompanyAboutResponse> Response = await Service.SelectAsync(Model);
			return new Response<CompanyAboutResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/companyaboutsingle")]
		public async Task<Response<CompanyAboutResponse>> GetSingle([FromQuery] CompanyAboutSelectDto Model)
		{
			Response<CompanyAboutResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CompanyAboutResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}