namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
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
		[EndpointName("networkaction")]
		[EndpointSummary("this is summary of create a new networkaction")]
		[EndpointDescription("this is description of create a new networkaction")]
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
        [EndpointName("getnetworkaction")]
        [EndpointSummary("you can use get data from networkaction API")]
        [EndpointDescription("you can use get data from networkaction API")]
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