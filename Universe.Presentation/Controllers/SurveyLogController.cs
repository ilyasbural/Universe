﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class SurveyLogController : ControllerBase
	{
		readonly ISurveyLogService Service;
		public SurveyLogController(ISurveyLogService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/surveylog")]
        [Produces(typeof(Response<SurveyLogResponse>))]
		[EndpointName("surveylog")]
		[EndpointSummary("this is summary of create a new surveylog")]
		[EndpointDescription("this is description of create a new surveylog")]
		public async Task<Response<SurveyLogResponse>> Create([FromBody] SurveyLogRegisterDto Model)
		{
			Response<SurveyLogResponse> Response = await Service.InsertAsync(Model);
			return new Response<SurveyLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/surveylog")]
		[Produces(typeof(Response<SurveyLogResponse>))]
		[EndpointName("updatesurveylog")]
		[EndpointSummary("you can use for update using surveylog API")]
		[EndpointDescription("you can use for update using surveylog API")]
		public async Task<Response<SurveyLogResponse>> Update([FromBody] SurveyLogUpdateDto Model)
		{
			Response<SurveyLogResponse> Response = await Service.UpdateAsync(Model);
			return new Response<SurveyLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/surveylog")]
        [Produces(typeof(Response<SurveyLogResponse>))]
        [EndpointName("deletesurveylog")]
        [EndpointSummary("you can delete surveylog using this API")]
        [EndpointDescription("you can delete surveylog using this API")]
        public async Task<Response<SurveyLogResponse>> Delete([FromBody] SurveyLogDeleteDto Model)
		{
			Response<SurveyLogResponse> Response = await Service.DeleteAsync(Model);
			return new Response<SurveyLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/surveylog")]
        [Produces(typeof(Response<SurveyLogResponse>))]
        [EndpointName("getsurveylog")]
        [EndpointSummary("you can use get data from surveylog API")]
        [EndpointDescription("you can use get data from surveylog API")]
        public async Task<Response<SurveyLogResponse>> Get([FromQuery] SurveyLogSelectDto Model)
		{
			Response<SurveyLogResponse> Response = await Service.SelectAsync(Model);
			return new Response<SurveyLogResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/surveylogsingle")]
        [Produces(typeof(Response<SurveyLogResponse>))]
        [EndpointName("getsinglesurveylog")]
        [EndpointSummary("you can use get data from surveylog API")]
        [EndpointDescription("you can use get data from surveylog API")]
        public async Task<Response<SurveyLogResponse>> GetSingle([FromQuery] SurveyLogSelectDto Model)
		{
			Response<SurveyLogResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<SurveyLogResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}