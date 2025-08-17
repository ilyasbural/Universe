namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class AnnounceLogController : ControllerBase
	{
		readonly IAnnounceLogService Service;
		public AnnounceLogController(IAnnounceLogService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/announcelog")]
		[Produces(typeof(Response<AnnounceLogResponse>))]
		public async Task<Response<AnnounceLogResponse>> Create([FromBody] AnnounceLogRegisterDto Model)
		{
			Response<AnnounceLogResponse> Response = await Service.InsertAsync(Model);
			return new Response<AnnounceLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/announcelog")]
		[Produces(typeof(Response<AnnounceLogResponse>))]
		public async Task<Response<AnnounceLogResponse>> Update([FromBody] AnnounceLogUpdateDto Model)
		{
			Response<AnnounceLogResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AnnounceLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/announcelog")]
        [Produces(typeof(Response<AnnounceLogResponse>))]
        public async Task<Response<AnnounceLogResponse>> Delete([FromBody] AnnounceLogDeleteDto Model)
		{
			Response<AnnounceLogResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AnnounceLogResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/announcelog")]
        [Produces(typeof(Response<AnnounceLogResponse>))]
        public async Task<Response<AnnounceLogResponse>> Get([FromQuery] AnnounceLogSelectDto Model)
		{
			Response<AnnounceLogResponse> Response = await Service.SelectAsync(Model);
			return new Response<AnnounceLogResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/announcelogsingle")]
        [Produces(typeof(Response<AnnounceResponse>))]
        public async Task<Response<AnnounceLogResponse>> GetSingle([FromQuery] AnnounceLogSelectDto Model)
		{
			Response<AnnounceLogResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AnnounceLogResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}