namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class NetworkController : ControllerBase
	{
		readonly INetworkService Service;
		public NetworkController(INetworkService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/network")]
        [Produces(typeof(Response<NetworkResponse>))]
		[EndpointName("network")]
		[EndpointSummary("this is summary of create a new network")]
		[EndpointDescription("this is description of create a new network")]
		public async Task<Response<NetworkResponse>> Create([FromBody] NetworkRegisterDto Model)
		{
			Response<NetworkResponse> Response = await Service.InsertAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/network")]
		[Produces(typeof(Response<NetworkResponse>))]
		[EndpointName("updatenetwork")]
		[EndpointSummary("you can use for update using network API")]
		[EndpointDescription("you can use for update using network API")]
		public async Task<Response<NetworkResponse>> Update([FromBody] NetworkUpdateDto Model)
		{
			Response<NetworkResponse> Response = await Service.UpdateAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/network")]
        [Produces(typeof(Response<NetworkResponse>))]
        [EndpointName("deletenetwork")]
        [EndpointSummary("you can delete network using this API")]
        [EndpointDescription("you can delete network using this API")]
        public async Task<Response<NetworkResponse>> Delete([FromBody] NetworkDeleteDto Model)
		{
			Response<NetworkResponse> Response = await Service.DeleteAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/network")]
        [Produces(typeof(Response<NetworkResponse>))]
        [EndpointName("getnetwork")]
        [EndpointSummary("you can use get data from network API")]
        [EndpointDescription("you can use get data from network API")]
        public async Task<Response<NetworkResponse>> Get([FromQuery] NetworkSelectDto Model)
		{
			Response<NetworkResponse> Response = await Service.SelectAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/networksingle")]
        [Produces(typeof(Response<NetworkResponse>))]
        [EndpointName("getnetworksingle")]
        [EndpointSummary("you can use get single data from network API")]
        [EndpointDescription("you can use get single data from network API")]
        public async Task<Response<NetworkResponse>> GetSingle([FromQuery] NetworkSelectDto Model)
		{
			Response<NetworkResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<NetworkResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}