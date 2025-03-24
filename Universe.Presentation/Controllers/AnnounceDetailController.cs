namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

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