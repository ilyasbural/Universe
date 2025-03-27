namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class CompanyDetailController : ControllerBase
	{
		readonly ICompanyDetailService Service;
		public CompanyDetailController(ICompanyDetailService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/companydetail")]
		[Produces(typeof(Response<CompanyDetailResponse>))]
		[EndpointName("createcompanydetail")]
		[EndpointSummary("this is summary of create a new companydetail")]
		[EndpointDescription("this is description of create a new companydetail")]
		public async Task<Response<CompanyDetailResponse>> Create([FromBody] CompanyDetailRegisterDto Model)
		{
			Response<CompanyDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<CompanyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/companydetail")]
		[Produces(typeof(Response<CompanyDetailResponse>))]
		[EndpointName("updatecompanydetail")]
		[EndpointSummary("you can use for update using companydetail API")]
		[EndpointDescription("you can use for update using companydetail API")]
		public async Task<Response<CompanyDetailResponse>> Update([FromBody] CompanyDetailUpdateDto Model)
		{
			Response<CompanyDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CompanyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/companydetail")]
        [Produces(typeof(Response<CompanyDetailResponse>))]
        [EndpointName("deletecompanydetail")]
        [EndpointSummary("you can delete companydetail using this API")]
        [EndpointDescription("you can delete companydetail using this API")]
        public async Task<Response<CompanyDetailResponse>> Delete([FromBody] CompanyDetailDeleteDto Model)
		{
			Response<CompanyDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CompanyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/companydetail")]
        [Produces(typeof(Response<CompanyDetailResponse>))]
        [EndpointName("getcompanydetail")]
        [EndpointSummary("you can use get data from companydetail API")]
        [EndpointDescription("you can use get data from companydetail API")]
        public async Task<Response<CompanyDetailResponse>> Get([FromQuery] CompanyDetailSelectDto Model)
		{
			Response<CompanyDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<CompanyDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/companydetailsingle")]
        [Produces(typeof(Response<CompanyDetailResponse>))]
        [EndpointName("getcompanydetailsingle")]
        [EndpointSummary("you can use get single data from companydetailsingle API")]
        [EndpointDescription("you can use get single data from companydetailsingle API")]
        public async Task<Response<CompanyDetailResponse>> GetSingle([FromQuery] CompanyDetailSelectDto Model)
		{
			Response<CompanyDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CompanyDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}