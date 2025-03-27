namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class JobPostingController : ControllerBase
	{
		readonly IJobPostingService Service;
		public JobPostingController(IJobPostingService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/jobposting")]
        [Produces(typeof(Response<JobPostingResponse>))]
		[EndpointName("jobposting")]
		[EndpointSummary("this is summary of create a new jobposting")]
		[EndpointDescription("this is description of create a new jobposting")]
		public async Task<Response<JobPostingResponse>> Create([FromBody] JobPostingRegisterDto Model)
		{
			Response<JobPostingResponse> Response = await Service.InsertAsync(Model);
			return new Response<JobPostingResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/jobposting")]
		[Produces(typeof(Response<JobPostingResponse>))]
		[EndpointName("updatejobposting")]
		[EndpointSummary("you can use for update using jobposting API")]
		[EndpointDescription("you can use for update using jobposting API")]
		public async Task<Response<JobPostingResponse>> Update([FromBody] JobPostingUpdateDto Model)
		{
			Response<JobPostingResponse> Response = await Service.UpdateAsync(Model);
			return new Response<JobPostingResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/jobposting")]
		public async Task<Response<JobPostingResponse>> Delete([FromBody] JobPostingDeleteDto Model)
		{
			Response<JobPostingResponse> Response = await Service.DeleteAsync(Model);
			return new Response<JobPostingResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/jobposting")]
        [Produces(typeof(Response<JobPostingResponse>))]
        [EndpointName("getjobposting")]
        [EndpointSummary("you can use get data from jobposting API")]
        [EndpointDescription("you can use get data from jobposting API")]
        public async Task<Response<JobPostingResponse>> Get([FromQuery] JobPostingSelectDto Model)
		{
			Response<JobPostingResponse> Response = await Service.SelectAsync(Model);
			return new Response<JobPostingResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/jobpostingsingle")]
        [Produces(typeof(Response<JobPostingResponse>))]
        [EndpointName("getjobpostingsingle")]
        [EndpointSummary("you can use get single data from jobposting API")]
        [EndpointDescription("you can use get single data from jobposting API")]
        public async Task<Response<JobPostingResponse>> GetSingle([FromQuery] JobPostingSelectDto Model)
		{
			Response<JobPostingResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<JobPostingResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}