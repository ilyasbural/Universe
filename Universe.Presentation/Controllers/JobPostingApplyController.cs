﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class JobPostingApplyController : ControllerBase
	{
		readonly IJobPostingApplyService Service;
		public JobPostingApplyController(IJobPostingApplyService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/jobpostingapply")]
        [Produces(typeof(Response<JobPostingApplyResponse>))]
		[EndpointName("jobpostingapply")]
		[EndpointSummary("this is summary of create a new jobpostingapply")]
		[EndpointDescription("this is description of create a new jobpostingapply")]
		public async Task<Response<JobPostingApplyResponse>> Create([FromBody] JobPostingApplyRegisterDto Model)
		{
			Response<JobPostingApplyResponse> Response = await Service.InsertAsync(Model);
			return new Response<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/jobpostingapply")]
		[Produces(typeof(Response<JobPostingApplyResponse>))]
		[EndpointName("updatejobpostingapply")]
		[EndpointSummary("you can use for update using jobpostingapply API")]
		[EndpointDescription("you can use for update using jobpostingapply API")]
		public async Task<Response<JobPostingApplyResponse>> Update([FromBody] JobPostingApplyUpdateDto Model)
		{
			Response<JobPostingApplyResponse> Response = await Service.UpdateAsync(Model);
			return new Response<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/jobpostingapply")]
        [Produces(typeof(Response<JobPostingApplyResponse>))]
        [EndpointName("deletejobpostingapply")]
        [EndpointSummary("you can delete jobpostingapply using this API")]
        [EndpointDescription("you can delete jobpostingapply using this API")]
        public async Task<Response<JobPostingApplyResponse>> Delete([FromBody] JobPostingApplyDeleteDto Model)
		{
			Response<JobPostingApplyResponse> Response = await Service.DeleteAsync(Model);
			return new Response<JobPostingApplyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/jobpostingapply")]
        [Produces(typeof(Response<JobPostingApplyResponse>))]
        [EndpointName("getjobpostingapply")]
        [EndpointSummary("you can use get data from jobpostingapply API")]
        [EndpointDescription("you can use get data from jobpostingapply API")]
        public async Task<Response<JobPostingApplyResponse>> Get([FromQuery] JobPostingApplySelectDto Model)
		{
			Response<JobPostingApplyResponse> Response = await Service.SelectAsync(Model);
			return new Response<JobPostingApplyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/jobpostingapplysingle")]
        [Produces(typeof(Response<JobPostingApplyResponse>))]
        [EndpointName("getjobpostingapplysingle")]
        [EndpointSummary("you can use get single data from jobpostingapply API")]
        [EndpointDescription("you can use get single data from jobpostingapply API")]
        public async Task<Response<JobPostingApplyResponse>> GetSingle([FromQuery] JobPostingApplySelectDto Model)
		{
			Response<JobPostingApplyResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<JobPostingApplyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}