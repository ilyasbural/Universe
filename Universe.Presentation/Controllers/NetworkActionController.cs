namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class NetworkActionController : ControllerBase
	{
		readonly INetworkActionService Service;
		public NetworkActionController(INetworkActionService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/networkaction")]
        [Produces(typeof(Response<NetworkActionResponse>))]
		public async Task<Response<NetworkActionResponse>> Create([FromBody] NetworkActionRegisterDto Model)
		{
			Response<NetworkActionResponse> Response = await Service.InsertAsync(Model);
			return new Response<NetworkActionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/networkaction")]
		[Produces(typeof(Response<NetworkActionResponse>))]
		public async Task<Response<NetworkActionResponse>> Update([FromBody] NetworkActionUpdateDto Model)
		{
			Response<NetworkActionResponse> Response = await Service.UpdateAsync(Model);
			return new Response<NetworkActionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/networkaction")]
        [Produces(typeof(Response<NetworkActionResponse>))]
        public async Task<Response<NetworkActionResponse>> Delete([FromBody] NetworkActionDeleteDto Model)
		{
			Response<NetworkActionResponse> Response = await Service.DeleteAsync(Model);
			return new Response<NetworkActionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/networkaction")]
        [Produces(typeof(Response<NetworkActionResponse>))]
        public async Task<Response<NetworkActionResponse>> Get([FromQuery] NetworkActionSelectDto Model)
		{
			Response<NetworkActionResponse> Response = await Service.SelectAsync(Model);
			return new Response<NetworkActionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/networkactionsingle")]
        [Produces(typeof(Response<NetworkActionResponse>))]
        public async Task<Response<NetworkActionResponse>> GetSingle([FromQuery] NetworkActionSelectDto Model)
		{
			Response<NetworkActionResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<NetworkActionResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}