﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

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