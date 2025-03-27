namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class MessageBoxController : ControllerBase
	{
		readonly IMessageBoxService Service;
		public MessageBoxController(IMessageBoxService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/messagebox")]
        [Produces(typeof(Response<MessageBoxResponse>))]
		[EndpointName("messagebox")]
		[EndpointSummary("this is summary of create a new messagebox")]
		[EndpointDescription("this is description of create a new messagebox")]
		public async Task<Response<MessageBoxResponse>> Create([FromBody] MessageBoxRegisterDto Model)
		{
			Response<MessageBoxResponse> Response = await Service.InsertAsync(Model);
			return new Response<MessageBoxResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/messagebox")]
		[Produces(typeof(Response<MessageBoxResponse>))]
		[EndpointName("updatemessagebox")]
		[EndpointSummary("you can use for update using messagebox API")]
		[EndpointDescription("you can use for update using messagebox API")]
		public async Task<Response<MessageBoxResponse>> Update([FromBody] MessageBoxUpdateDto Model)
		{
			Response<MessageBoxResponse> Response = await Service.UpdateAsync(Model);
			return new Response<MessageBoxResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/messagebox")]
        [Produces(typeof(Response<MessageBoxResponse>))]
        [EndpointName("deletemessagebox")]
        [EndpointSummary("you can delete messagebox using this API")]
        [EndpointDescription("you can delete messagebox using this API")]
        public async Task<Response<MessageBoxResponse>> Delete([FromBody] MessageBoxDeleteDto Model)
		{
			Response<MessageBoxResponse> Response = await Service.DeleteAsync(Model);
			return new Response<MessageBoxResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/messagebox")]
        [Produces(typeof(Response<MessageBoxResponse>))]
        [EndpointName("getmessagebox")]
        [EndpointSummary("you can use get data from messagebox API")]
        [EndpointDescription("you can use get data from messagebox API")]
        public async Task<Response<MessageBoxResponse>> Get([FromQuery] MessageBoxSelectDto Model)
		{
			Response<MessageBoxResponse> Response = await Service.SelectAsync(Model);
			return new Response<MessageBoxResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/messageboxsingle")]
        [Produces(typeof(Response<MessageBoxResponse>))]
        [EndpointName("getsinglemessagebox")]
        [EndpointSummary("you can use get data from messagebox API")]
        [EndpointDescription("you can use get data from messagebox API")]
        public async Task<Response<MessageBoxResponse>> GetSingle([FromQuery] MessageBoxSelectDto Model)
		{
			Response<MessageBoxResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<MessageBoxResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}