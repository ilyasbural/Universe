namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class CompanyFollowerController : ControllerBase
	{
		readonly ICompanyFollowerService Service;
		public CompanyFollowerController(ICompanyFollowerService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/companyfollower")]
		[Produces(typeof(Response<CompanyFollowerResponse>))]
		public async Task<Response<CompanyFollowerResponse>> Create([FromBody] CompanyFollowerRegisterDto Model)
		{
			Response<CompanyFollowerResponse> Response = await Service.InsertAsync(Model);
			return new Response<CompanyFollowerResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/companyfollower")]
		[Produces(typeof(Response<CompanyFollowerResponse>))]
		public async Task<Response<CompanyFollowerResponse>> Update([FromBody] CompanyFollowerUpdateDto Model)
		{
			Response<CompanyFollowerResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CompanyFollowerResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/companyfollower")]
        [Produces(typeof(Response<CompanyFollowerResponse>))]
        public async Task<Response<CompanyFollowerResponse>> Delete([FromBody] CompanyFollowerDeleteDto Model)
		{
			Response<CompanyFollowerResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CompanyFollowerResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/companyfollower")]
        [Produces(typeof(Response<CompanyFollowerResponse>))]
        public async Task<Response<CompanyFollowerResponse>> Get([FromQuery] CompanyFollowerSelectDto Model)
		{
			Response<CompanyFollowerResponse> Response = await Service.SelectAsync(Model);
			return new Response<CompanyFollowerResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/companyfollowersingle")]
        [Produces(typeof(Response<CompanyFollowerResponse>))]
        public async Task<Response<CompanyFollowerResponse>> GetSingle([FromQuery] CompanyFollowerSelectDto Model)
		{
			Response<CompanyFollowerResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CompanyFollowerResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}