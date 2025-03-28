﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

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
        [Produces(typeof(Response<CompanyAboutResponse>))]
		[EndpointName("createcompanyabout")]
		[EndpointSummary("this is summary of create a new companyabout")]
		[EndpointDescription("this is description of create a new companyabout")]
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
		[Produces(typeof(Response<CompanyAboutResponse>))]
		[EndpointName("updatecompanyabout")]
		[EndpointSummary("you can use for update using companyabout API")]
		[EndpointDescription("you can use for update using companyabout API")]
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
        [Produces(typeof(Response<CompanyAboutResponse>))]
        [EndpointName("deletecompanyabout")]
        [EndpointSummary("you can delete companyabout using this API")]
        [EndpointDescription("you can delete companyabout using this API")]
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
        [Produces(typeof(Response<CompanyAboutResponse>))]
        [EndpointName("getcompanyabout")]
        [EndpointSummary("you can use get data from companyabout API")]
        [EndpointDescription("you can use get data from companyabout API")]
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
        [Produces(typeof(Response<CompanyAboutResponse>))]
        [EndpointName("getcompanyaboutsingle")]
        [EndpointSummary("you can use get single data from companyaboutsingle API")]
        [EndpointDescription("you can use get single data from companyaboutsingle API")]
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