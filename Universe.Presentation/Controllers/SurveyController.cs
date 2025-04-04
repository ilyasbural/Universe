﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class SurveyController : ControllerBase
	{
		readonly ISurveyService Service;
		public SurveyController(ISurveyService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/survey")]
        [Produces(typeof(Response<SurveyResponse>))]
		[EndpointName("survey")]
		[EndpointSummary("this is summary of create a new survey")]
		[EndpointDescription("this is description of create a new survey")]
		public async Task<Response<SurveyResponse>> Create([FromBody] SurveyRegisterDto Model)
		{
			Response<SurveyResponse> Response = await Service.InsertAsync(Model);
			return new Response<SurveyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/survey")]
		[Produces(typeof(Response<SurveyResponse>))]
		[EndpointName("updatesurvey")]
		[EndpointSummary("you can use for update using survey API")]
		[EndpointDescription("you can use for update using survey API")]
		public async Task<Response<SurveyResponse>> Update([FromBody] SurveyUpdateDto Model)
		{
			Response<SurveyResponse> Response = await Service.UpdateAsync(Model);
			return new Response<SurveyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/survey")]
        [Produces(typeof(Response<SurveyResponse>))]
        [EndpointName("deletesurvey")]
        [EndpointSummary("you can delete survey using this API")]
        [EndpointDescription("you can delete survey using this API")]
        public async Task<Response<SurveyResponse>> Delete([FromBody] SurveyDeleteDto Model)
		{
			Response<SurveyResponse> Response = await Service.DeleteAsync(Model);
			return new Response<SurveyResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/survey")]
        [Produces(typeof(Response<SurveyResponse>))]
        [EndpointName("getsurvey")]
        [EndpointSummary("you can use get data from survey API")]
        [EndpointDescription("you can use get data from survey API")]
        public async Task<Response<SurveyResponse>> Get([FromQuery] SurveySelectDto Model)
		{
			Response<SurveyResponse> Response = await Service.SelectAsync(Model);
			return new Response<SurveyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/surveysingle")]
        [Produces(typeof(Response<SurveyResponse>))]
        [EndpointName("getsinglesurvey")]
        [EndpointSummary("you can use get data from survey API")]
        [EndpointDescription("you can use get data from survey API")]
        public async Task<Response<SurveyResponse>> GetSingle([FromQuery] SurveySelectDto Model)
		{
			Response<SurveyResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<SurveyResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}