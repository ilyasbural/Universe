﻿namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

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
        [Produces(typeof(Response<EmojiResponse>))]
		[EndpointName("createemoji")]
		[EndpointSummary("this is summary of create a new emoji")]
		[EndpointDescription("this is description of create a new emoji")]
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
		[Produces(typeof(Response<EmojiResponse>))]
		[EndpointName("updateemoji")]
		[EndpointSummary("you can use for update using emoji API")]
		[EndpointDescription("you can use for update using emoji API")]
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
        [Produces(typeof(Response<EmojiResponse>))]
        [EndpointName("deleteemoji")]
        [EndpointSummary("you can delete emoji using this API")]
        [EndpointDescription("you can delete emoji using this API")]
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
        [Produces(typeof(Response<EmojiResponse>))]
        [EndpointName("getemoji")]
        [EndpointSummary("you can use get data from emoji API")]
        [EndpointDescription("you can use get data from emoji API")]
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
        [Produces(typeof(Response<EmojiResponse>))]
        [EndpointName("getsingleemoji")]
        [EndpointSummary("you can use get single data from emoji API")]
        [EndpointDescription("you can use get single data from emoji API")]
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