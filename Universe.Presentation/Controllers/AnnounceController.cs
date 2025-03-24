namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class AnnounceController : ControllerBase
	{
		readonly IAnnounceService Service;
		public AnnounceController(IAnnounceService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/announce")]
		public async Task<Response<AnnounceResponse>> Create([FromBody] AnnounceRegisterDto Model)
		{
			Response<AnnounceResponse> Response = await Service.InsertAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/announce")]
		public async Task<Response<AnnounceResponse>> Update([FromBody] AnnounceUpdateDto Model)
		{
			Response<AnnounceResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/announce")]
		public async Task<Response<AnnounceResponse>> Delete([FromBody] AnnounceDeleteDto Model)
		{
			Response<AnnounceResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/announce")]
		public async Task<Response<AnnounceResponse>> Get([FromQuery] AnnounceSelectDto Model)
		{
			Response<AnnounceResponse> Response = await Service.SelectAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/announcesingle")]
		public async Task<Response<AnnounceResponse>> GetSingle([FromQuery] AnnounceSelectDto Model)
		{
			Response<AnnounceResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AnnounceResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}