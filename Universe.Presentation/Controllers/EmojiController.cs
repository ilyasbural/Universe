namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class EmojiController : ControllerBase
	{
		readonly IEmojiService Service;
		public EmojiController(IEmojiService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/emoji")]
		public async Task<Response<EmojiResponse>> Create([FromBody] EmojiRegisterDto Model)
		{
			Response<EmojiResponse> Response = await Service.InsertAsync(Model);
			return new Response<EmojiResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/emoji")]
		public async Task<Response<EmojiResponse>> Update([FromBody] EmojiUpdateDto Model)
		{
			Response<EmojiResponse> Response = await Service.UpdateAsync(Model);
			return new Response<EmojiResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/emoji")]
		public async Task<Response<EmojiResponse>> Delete([FromBody] EmojiDeleteDto Model)
		{
			Response<EmojiResponse> Response = await Service.DeleteAsync(Model);
			return new Response<EmojiResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/emoji")]
		public async Task<Response<EmojiResponse>> Get([FromQuery] EmojiSelectDto Model)
		{
			Response<EmojiResponse> Response = await Service.SelectAsync(Model);
			return new Response<EmojiResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/emojisingle")]
		public async Task<Response<EmojiResponse>> GetSingle([FromQuery] EmojiSelectDto Model)
		{
			Response<EmojiResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<EmojiResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}