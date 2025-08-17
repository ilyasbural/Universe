namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class NetworkDetailController : ControllerBase
	{
		readonly INetworkDetailService Service;
		public NetworkDetailController(INetworkDetailService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/networkdetail")]
        [Produces(typeof(Response<NetworkDetailResponse>))]
		public async Task<Response<NetworkDetailResponse>> Create([FromBody] NetworkDetailRegisterDto Model)
		{
			Response<NetworkDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<NetworkDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/networkdetail")]
		[Produces(typeof(Response<NetworkDetailResponse>))]
		public async Task<Response<NetworkDetailResponse>> Update([FromBody] NetworkDetailUpdateDto Model)
		{
			Response<NetworkDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<NetworkDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/networkdetail")]
        [Produces(typeof(Response<NetworkDetailResponse>))]
        public async Task<Response<NetworkDetailResponse>> Delete([FromBody] NetworkDetailDeleteDto Model)
		{
			Response<NetworkDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<NetworkDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/networkdetail")]
        [Produces(typeof(Response<NetworkDetailResponse>))]
        public async Task<Response<NetworkDetailResponse>> Get([FromQuery] NetworkDetailSelectDto Model)
		{
			Response<NetworkDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<NetworkDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/networkdetailsingle")]
        [Produces(typeof(Response<NetworkDetailResponse>))]
        public async Task<Response<NetworkDetailResponse>> GetSingle([FromQuery] NetworkDetailSelectDto Model)
		{
			Response<NetworkDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<NetworkDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}