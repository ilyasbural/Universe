namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

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