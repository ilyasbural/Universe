namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserPublishController : ControllerBase
	{
		readonly IUserPublishService Service;
		public UserPublishController(IUserPublishService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userpublish")]
        [Produces(typeof(Response<UserPublishResponse>))]
		[EndpointName("userpublish")]
		[EndpointSummary("this is summary of create a new userpublish")]
		[EndpointDescription("this is description of create a new userpublish")]
		public async Task<Response<UserPublishResponse>> Create([FromBody] UserPublishRegisterDto Model)
		{
			Response<UserPublishResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserPublishResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userpublish")]
		[Produces(typeof(Response<UserPublishResponse>))]
		[EndpointName("updateuserpublish")]
		[EndpointSummary("you can use for update using userpublish API")]
		[EndpointDescription("you can use for update using userpublish API")]
		public async Task<Response<UserPublishResponse>> Update([FromBody] UserPublishUpdateDto Model)
		{
			Response<UserPublishResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserPublishResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userpublish")]
		public async Task<Response<UserPublishResponse>> Delete([FromBody] UserPublishDeleteDto Model)
		{
			Response<UserPublishResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserPublishResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userpublish")]
        [Produces(typeof(Response<UserPublishResponse>))]
        [EndpointName("getuserpublish")]
        [EndpointSummary("you can use get data from userpublish API")]
        [EndpointDescription("you can use get data from userpublish API")]
        public async Task<Response<UserPublishResponse>> Get([FromQuery] UserPublishSelectDto Model)
		{
			Response<UserPublishResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserPublishResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userpublishsingle")]
        [Produces(typeof(Response<UserPublishResponse>))]
        [EndpointName("getuserpublishsingle")]
        [EndpointSummary("you can use get single data from userpublish API")]
        [EndpointDescription("you can use get single data from userpublish API")]
        public async Task<Response<UserPublishResponse>> GetSingle([FromQuery] UserPublishSelectDto Model)
		{
			Response<UserPublishResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserPublishResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}