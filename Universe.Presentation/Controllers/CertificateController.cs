namespace Universe.Presentation.Controllers
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

        [HttpPost]
        [Route("api/certificate")]
		[Produces(typeof(Response<CertificateResponse>))]
		[EndpointName("createcertificate")]
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
		[Produces(typeof(Response<CertificateResponse>))]
		[EndpointName("updatecertificate")]
		[EndpointSummary("you can use for update using certificate API")]
		[EndpointDescription("you can use for update using certificate API")]
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
        [Produces(typeof(Response<CertificateResponse>))]
        [EndpointName("getcertificate")]
        [EndpointSummary("you can use get data from certificate API")]
        [EndpointDescription("you can use get data from certificate API")]
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
        [Produces(typeof(Response<CertificateResponse>))]
        [EndpointName("getcertificatesingle")]
        [EndpointSummary("you can use get single data from certificatesingle API")]
        [EndpointDescription("you can use get single data from certificatesingle API")]
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