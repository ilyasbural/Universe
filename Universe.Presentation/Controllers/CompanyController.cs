namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class CompanyController : ControllerBase
	{
		readonly ICompanyService Service;
		public CompanyController(ICompanyService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/company")]
		[Produces(typeof(Response<CompanyResponse>))]
		[EndpointName("company")]
		[EndpointSummary("this is summary of create a new company")]
		[EndpointDescription("this is description of create a new company")]
		public async Task<Response<CompanyResponse>> Create([FromBody] CompanyRegisterDto Model)
		{
			Response<CompanyResponse> Response = await Service.InsertAsync(Model);
			return new Response<CompanyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/company")]
		public async Task<Response<CompanyResponse>> Update([FromBody] CompanyUpdateDto Model)
		{
			Response<CompanyResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CompanyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/company")]
		public async Task<Response<CompanyResponse>> Delete([FromBody] CompanyDeleteDto Model)
		{
			Response<CompanyResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CompanyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/company")]
		public async Task<Response<CompanyResponse>> Get([FromQuery] CompanySelectDto Model)
		{
			Response<CompanyResponse> Response = await Service.SelectAsync(Model);
			return new Response<CompanyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/companysingle")]
		public async Task<Response<CompanyResponse>> GetSingle([FromQuery] CompanySelectDto Model)
		{
			Response<CompanyResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CompanyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}