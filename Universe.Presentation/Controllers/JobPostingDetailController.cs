﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class JobPostingDetailController : ControllerBase
	{
		readonly IJobPostingDetailService Service;
		public JobPostingDetailController(IJobPostingDetailService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/jobpostingdetail")]
        [Produces(typeof(Response<JobPostingDetailResponse>))]
		[EndpointName("jobpostingdetail")]
		[EndpointSummary("this is summary of create a new jobpostingdetail")]
		[EndpointDescription("this is description of create a new jobpostingdetail")]
		public async Task<Response<JobPostingDetailResponse>> Create([FromBody] JobPostingDetailRegisterDto Model)
		{
			Response<JobPostingDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<JobPostingDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/jobpostingdetail")]
		[Produces(typeof(Response<JobPostingDetailResponse>))]
		[EndpointName("updatejobpostingdetail")]
		[EndpointSummary("you can use for update using jobpostingdetail API")]
		[EndpointDescription("you can use for update using jobpostingdetail API")]
		public async Task<Response<JobPostingDetailResponse>> Update([FromBody] JobPostingDetailUpdateDto Model)
		{
			Response<JobPostingDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<JobPostingDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/jobpostingdetail")]
        [Produces(typeof(Response<JobPostingDetailResponse>))]
        [EndpointName("deletejobpostingdetail")]
        [EndpointSummary("you can delete jobpostingdetail using this API")]
        [EndpointDescription("you can delete jobpostingdetail using this API")]
        public async Task<Response<JobPostingDetailResponse>> Delete([FromBody] JobPostingDetailDeleteDto Model)
		{
			Response<JobPostingDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<JobPostingDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/jobpostingdetail")]
        [Produces(typeof(Response<JobPostingDetailResponse>))]
        [EndpointName("getjobpostingdetail")]
        [EndpointSummary("you can use get data from jobpostingdetail API")]
        [EndpointDescription("you can use get data from jobpostingdetail API")]
        public async Task<Response<JobPostingDetailResponse>> Get([FromQuery] JobPostingDetailSelectDto Model)
		{
			Response<JobPostingDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<JobPostingDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/jobpostingdetailsingle")]
        [Produces(typeof(Response<JobPostingDetailResponse>))]
        [EndpointName("getjobpostingdetailsingle")]
        [EndpointSummary("you can use get single data from jobpostingdetail API")]
        [EndpointDescription("you can use get single data from jobpostingdetail API")]
        public async Task<Response<JobPostingDetailResponse>> GetSingle([FromQuery] JobPostingDetailSelectDto Model)
		{
			Response<JobPostingDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<JobPostingDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}