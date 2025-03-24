namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

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