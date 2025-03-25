﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class CertificateController : ControllerBase
	{
		readonly ICertificateService Service;
		public CertificateController(ICertificateService service)
		{
			Service = service;
		}

		[Route("api/certificate")]
		[HttpPost("create")]
		[Produces(typeof(Response<CertificateResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new certificate")]
		[EndpointDescription("this is description of create a new certificate")]
		public async Task<Response<CertificateResponse>> Create([FromBody] CertificateRegisterDto Model)
		{
			Response<CertificateResponse> Response = await Service.InsertAsync(Model);
			return new Response<CertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/certificate")]
		public async Task<Response<CertificateResponse>> Update([FromBody] CertificateUpdateDto Model)
		{
			Response<CertificateResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/certificate")]
		public async Task<Response<CertificateResponse>> Delete([FromBody] CertificateDeleteDto Model)
		{
			Response<CertificateResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/certificate")]
		public async Task<Response<CertificateResponse>> Get([FromQuery] CertificateSelectDto Model)
		{
			Response<CertificateResponse> Response = await Service.SelectAsync(Model);
			return new Response<CertificateResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/certificatesingle")]
		public async Task<Response<CertificateResponse>> GetSingle([FromQuery] CertificateSelectDto Model)
		{
			Response<CertificateResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CertificateResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}