namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class CollegeController : ControllerBase
	{
		readonly ICollegeService Service;
		public CollegeController(ICollegeService service)
		{
			Service = service;
		}

		
		[HttpPost]
        [Route("api/college")]
        [Produces(typeof(Response<CollegeResponse>))]
		[EndpointName("college")]
		[EndpointSummary("this is summary of create a new college")]
		[EndpointDescription("this is description of create a new college")]
		public async Task<Response<CollegeResponse>> Create([FromBody] CollegeRegisterDto Model)
		{
			Response<CollegeResponse> Response = await Service.InsertAsync(Model);
			return new Response<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/college")]
		public async Task<Response<CollegeResponse>> Update([FromBody] CollegeUpdateDto Model)
		{
			Response<CollegeResponse> Response = await Service.UpdateAsync(Model);
			return new Response<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/college")]
		public async Task<Response<CollegeResponse>> Delete([FromBody] CollegeDeleteDto Model)
		{
			Response<CollegeResponse> Response = await Service.DeleteAsync(Model);
			return new Response<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/college")]
        [Produces(typeof(Response<CollegeResponse>))]
        [EndpointName("getcollege")]
        [EndpointSummary("you can use get data from college API")]
        [EndpointDescription("you can use get data from college API")]
        public async Task<Response<CollegeResponse>> Get([FromQuery] CollegeSelectDto Model)
		{
			Response<CollegeResponse> Response = await Service.SelectAsync(Model);
			return new Response<CollegeResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/collegesingle")]
		public async Task<Response<CollegeResponse>> GetSingle([FromQuery] CollegeSelectDto Model)
		{
			Response<CollegeResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<CollegeResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}