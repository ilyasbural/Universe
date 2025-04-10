﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class SurveyDetailController : ControllerBase
	{
		readonly ISurveyDetailService Service;
		public SurveyDetailController(ISurveyDetailService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/surveydetail")]
        [Produces(typeof(Response<SurveyDetailResponse>))]
		[EndpointName("surveydetail")]
		[EndpointSummary("this is summary of create a new surveydetail")]
		[EndpointDescription("this is description of create a new surveydetail")]
		public async Task<Response<SurveyDetailResponse>> Create([FromBody] SurveyDetailRegisterDto Model)
		{
			Response<SurveyDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<SurveyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/surveydetail")]
		[Produces(typeof(Response<SurveyDetailResponse>))]
		[EndpointName("updatesurveydetail")]
		[EndpointSummary("you can use for update using surveydetail API")]
		[EndpointDescription("you can use for update using surveydetail API")]
		public async Task<Response<SurveyDetailResponse>> Update([FromBody] SurveyDetailUpdateDto Model)
		{
			Response<SurveyDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<SurveyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/surveydetail")]
        [Produces(typeof(Response<SurveyDetailResponse>))]
        [EndpointName("deletesurveydetail")]
        [EndpointSummary("you can delete surveydetail using this API")]
        [EndpointDescription("you can delete surveydetail using this API")]
        public async Task<Response<SurveyDetailResponse>> Delete([FromBody] SurveyDetailDeleteDto Model)
		{
			Response<SurveyDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<SurveyDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/surveydetail")]
        [Produces(typeof(Response<SurveyDetailResponse>))]
        [EndpointName("getsurveydetail")]
        [EndpointSummary("you can use get data from surveydetail API")]
        [EndpointDescription("you can use get data from surveydetail API")]
        public async Task<Response<SurveyDetailResponse>> Get([FromQuery] SurveyDetailSelectDto Model)
		{
			Response<SurveyDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<SurveyDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/surveydetailsingle")]
        [Produces(typeof(Response<SurveyDetailResponse>))]
        [EndpointName("getsurveydetailsingle")]
        [EndpointSummary("you can use get single data from surveydetailsingle API")]
        [EndpointDescription("you can use get single data from surveydetailsingle API")]
        public async Task<Response<SurveyDetailResponse>> GetSingle([FromQuery] SurveyDetailSelectDto Model)
		{
			Response<SurveyDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<SurveyDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}