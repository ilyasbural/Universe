﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class AnnounceDetailController : ControllerBase
	{
		readonly IAnnounceDetailService Service;
		public AnnounceDetailController(IAnnounceDetailService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/announcedetail")]
		[Produces(typeof(Response<AnnounceDetailResponse>))]
		[EndpointName("createannouncedetail")]
		[EndpointSummary("this is summary of create a new announcedetail")]
		[EndpointDescription("this is description of create a new announcedetail")]
		public async Task<Response<AnnounceDetailResponse>> Create([FromBody] AnnounceDetailRegisterDto Model)
		{
			Response<AnnounceDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<AnnounceDetailResponse>
			{
                ResponseData = Response.ResponseData
            };
		}

		[HttpPut]
		[Route("api/announcedetail")]
		[Produces(typeof(Response<AnnounceDetailResponse>))]
		[EndpointName("updateannouncedetail")]
		[EndpointSummary("you can use for update using announcedetail API")]
		[EndpointDescription("you can use for update using announcedetail API")]
		public async Task<Response<AnnounceDetailResponse>> Update([FromBody] AnnounceDetailUpdateDto Model)
		{
			Response<AnnounceDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AnnounceDetailResponse>
			{
                ResponseData = Response.ResponseData
            };
		}

		[HttpDelete]
		[Route("api/announcedetail")]
        [Produces(typeof(Response<AnnounceDetailResponse>))]
        [EndpointName("deleteannouncedetail")]
        [EndpointSummary("you can delete announcedetail using this API")]
        [EndpointDescription("you can delete announcedetail using this API")]
        public async Task<Response<AnnounceDetailResponse>> Delete([FromBody] AnnounceDetailDeleteDto Model)
		{
			Response<AnnounceDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AnnounceDetailResponse>
			{
                ResponseData = Response.ResponseData
            };
		}

		[HttpGet]
		[Route("api/announcedetail")]
        [Produces(typeof(Response<AnnounceDetailResponse>))]
        [EndpointName("getannouncedetail")]
        [EndpointSummary("you can use get data from announcedetail API")]
        [EndpointDescription("you can use get data from announcedetail API")]
        public async Task<Response<AnnounceDetailResponse>> Get([FromQuery] AnnounceDetailSelectDto Model)
		{
			Response<AnnounceDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<AnnounceDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/announcedetailsingle")]
        [Produces(typeof(Response<AnnounceDetailResponse>))]
        [EndpointName("getannouncedetailsingle")]
        [EndpointSummary("you can use get single data from announcedetailsingle API")]
        [EndpointDescription("you can use get single data from announcedetailsingle API")]
        public async Task<Response<AnnounceDetailResponse>> GetSingle([FromQuery] AnnounceDetailSelectDto Model)
		{
			Response<AnnounceDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AnnounceDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}