namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserCertificateController : ControllerBase
	{
		readonly IUserCertificateService Service;
		public UserCertificateController(IUserCertificateService service)
		{
			Service = service;
		}

		[Route("api/usercertificate")]
		[HttpPost("create")]
		[Produces(typeof(Response<UserCertificateResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new usercertificate")]
		[EndpointDescription("this is description of create a new usercertificate")]
		public async Task<Response<UserCertificateResponse>> Create([FromBody] UserCertificateRegisterDto Model)
		{
			Response<UserCertificateResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/usercertificate")]
		public async Task<Response<UserCertificateResponse>> Update([FromBody] UserCertificateUpdateDto Model)
		{
			Response<UserCertificateResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/usercertificate")]
		public async Task<Response<UserCertificateResponse>> Delete([FromBody] UserCertificateDeleteDto Model)
		{
			Response<UserCertificateResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/usercertificate")]
		public async Task<Response<UserCertificateResponse>> Get([FromQuery] UserCertificateSelectDto Model)
		{
			Response<UserCertificateResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserCertificateResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/usercertificatesingle")]
		public async Task<Response<UserCertificateResponse>> GetSingle([FromQuery] UserCertificateSelectDto Model)
		{
			Response<UserCertificateResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserCertificateResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}