﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class SurveyHistoryController : ControllerBase
	{
		readonly ISurveyHistoryService Service;
		public SurveyHistoryController(ISurveyHistoryService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/surveyhistory")]
		public async Task<Response<SurveyHistoryResponse>> Create([FromBody] SurveyHistoryRegisterDto Model)
		{
			Response<SurveyHistoryResponse> Response = await Service.InsertAsync(Model);
			return new Response<SurveyHistoryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/surveyhistory")]
		public async Task<Response<SurveyHistoryResponse>> Update([FromBody] SurveyHistoryUpdateDto Model)
		{
			Response<SurveyHistoryResponse> Response = await Service.UpdateAsync(Model);
			return new Response<SurveyHistoryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/surveyhistory")]
		public async Task<Response<SurveyHistoryResponse>> Delete([FromBody] SurveyHistoryDeleteDto Model)
		{
			Response<SurveyHistoryResponse> Response = await Service.DeleteAsync(Model);
			return new Response<SurveyHistoryResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/surveyhistory")]
		public async Task<Response<SurveyHistoryResponse>> Get([FromQuery] SurveyHistorySelectDto Model)
		{
			Response<SurveyHistoryResponse> Response = await Service.SelectAsync(Model);
			return new Response<SurveyHistoryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/surveyhistorysingle")]
		public async Task<Response<SurveyHistoryResponse>> GetSingle([FromQuery] SurveyHistorySelectDto Model)
		{
			Response<SurveyHistoryResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<SurveyHistoryResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}