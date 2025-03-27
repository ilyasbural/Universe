namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class UserDetailController : ControllerBase
	{
		readonly IUserDetailService Service;
		public UserDetailController(IUserDetailService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/userdetail")]
        [Produces(typeof(Response<UserDetailResponse>))]
		[EndpointName("userdetail")]
		[EndpointSummary("this is summary of create a new userdetail")]
		[EndpointDescription("this is description of create a new userdetail")]
		public async Task<Response<UserDetailResponse>> Create([FromBody] UserDetailRegisterDto Model)
		{
			Response<UserDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/userdetail")]
		[Produces(typeof(Response<UserDetailResponse>))]
		[EndpointName("updateuserdetail")]
		[EndpointSummary("you can use for update using userdetail API")]
		[EndpointDescription("you can use for update using userdetail API")]
		public async Task<Response<UserDetailResponse>> Update([FromBody] UserDetailUpdateDto Model)
		{
			Response<UserDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/userdetail")]
        [Produces(typeof(Response<UserDetailResponse>))]
        [EndpointName("deleteuserdetail")]
        [EndpointSummary("you can delete userdetail using this API")]
        [EndpointDescription("you can delete userdetail using this API")]
        public async Task<Response<UserDetailResponse>> Delete([FromBody] UserDetailDeleteDto Model)
		{
			Response<UserDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/userdetail")]
        [Produces(typeof(Response<UserDetailResponse>))]
        [EndpointName("getuserdetail")]
        [EndpointSummary("you can use get data from userdetail API")]
        [EndpointDescription("you can use get data from userdetail API")]
        public async Task<Response<UserDetailResponse>> Get([FromQuery] UserDetailSelectDto Model)
		{
			Response<UserDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<UserDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/userdetailsingle")]
        [Produces(typeof(Response<UserDetailResponse>))]
        [EndpointName("getuserdetailsingle")]
        [EndpointSummary("you can use get single data from userdetailsingle API")]
        [EndpointDescription("you can use get single data from userdetailsingle API")]
        public async Task<Response<UserDetailResponse>> GetSingle([FromQuery] UserDetailSelectDto Model)
		{
			Response<UserDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<UserDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}