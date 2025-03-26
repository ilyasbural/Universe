namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class NetworkCommentController : ControllerBase
	{
		readonly INetworkCommentService Service;
		public NetworkCommentController(INetworkCommentService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/networkcomment")]
        [Produces(typeof(Response<NetworkCommentResponse>))]
		[EndpointName("networkcomment")]
		[EndpointSummary("this is summary of create a new networkcomment")]
		[EndpointDescription("this is description of create a new networkcomment")]
		public async Task<Response<NetworkCommentResponse>> Create([FromBody] NetworkCommentRegisterDto Model)
		{
			Response<NetworkCommentResponse> Response = await Service.InsertAsync(Model);
			return new Response<NetworkCommentResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/networkcomment")]
		public async Task<Response<NetworkCommentResponse>> Update([FromBody] NetworkCommentUpdateDto Model)
		{
			Response<NetworkCommentResponse> Response = await Service.UpdateAsync(Model);
			return new Response<NetworkCommentResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/networkcomment")]
		public async Task<Response<NetworkCommentResponse>> Delete([FromBody] NetworkCommentDeleteDto Model)
		{
			Response<NetworkCommentResponse> Response = await Service.DeleteAsync(Model);
			return new Response<NetworkCommentResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/networkcomment")]
        [Produces(typeof(Response<NetworkCommentResponse>))]
        [EndpointName("getemoji")]
        [EndpointSummary("you can use get data from networkcomment API")]
        [EndpointDescription("you can use get data from networkcomment API")]
        public async Task<Response<NetworkCommentResponse>> Get([FromQuery] NetworkCommentSelectDto Model)
		{
			Response<NetworkCommentResponse> Response = await Service.SelectAsync(Model);
			return new Response<NetworkCommentResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/networkcommentsingle")]
		public async Task<Response<NetworkCommentResponse>> GetSingle([FromQuery] NetworkCommentSelectDto Model)
		{
			Response<NetworkCommentResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<NetworkCommentResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}