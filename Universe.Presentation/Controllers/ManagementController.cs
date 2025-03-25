namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class ManagementController : ControllerBase
	{
		readonly IManagementService Service;
		public ManagementController(IManagementService service)
		{
			Service = service;
		}

		[Route("api/management")]
		[HttpPost("create")]
		[Produces(typeof(Response<ManagementResponse>))]
		[EndpointName("create")]
		[EndpointSummary("this is summary of create a new management")]
		[EndpointDescription("this is description of create a new management")]
		public async Task<Response<ManagementResponse>> Create([FromBody] ManagementRegisterDto Model)
		{
			Response<ManagementResponse> Response = await Service.InsertAsync(Model);
			return new Response<ManagementResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/management")]
		public async Task<Response<ManagementResponse>> Update([FromBody] ManagementUpdateDto Model)
		{
			Response<ManagementResponse> Response = await Service.UpdateAsync(Model);
			return new Response<ManagementResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/management")]
		public async Task<Response<ManagementResponse>> Delete([FromBody] ManagementDeleteDto Model)
		{
			Response<ManagementResponse> Response = await Service.DeleteAsync(Model);
			return new Response<ManagementResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/management")]
		public async Task<Response<ManagementResponse>> Get([FromQuery] ManagementSelectDto Model)
		{
			Response<ManagementResponse> Response = await Service.SelectAsync(Model);
			return new Response<ManagementResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/managementsingle")]
		public async Task<Response<ManagementResponse>> GetSingle([FromQuery] ManagementSelectDto Model)
		{
			Response<ManagementResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<ManagementResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}