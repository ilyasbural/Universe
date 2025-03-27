namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class ManagementEmailController : ControllerBase
	{
		readonly IManagementEmailService Service;
		public ManagementEmailController(IManagementEmailService service)
		{
			Service = service;
		}

		[HttpPost]
        [Route("api/managementemail")]
        [Produces(typeof(Response<ManagementEmailResponse>))]
		[EndpointName("managementemail")]
		[EndpointSummary("this is summary of create a new managementemail")]
		[EndpointDescription("this is description of create a new managementemail")]
		public async Task<Response<ManagementEmailResponse>> Create([FromBody] ManagementEmailRegisterDto Model)
		{
			Response<ManagementEmailResponse> Response = await Service.InsertAsync(Model);
			return new Response<ManagementEmailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/managementemail")]
		[Produces(typeof(Response<ManagementEmailResponse>))]
		[EndpointName("updatemanagementemail")]
		[EndpointSummary("you can use for update using managementemail API")]
		[EndpointDescription("you can use for update using managementemail API")]
		public async Task<Response<ManagementEmailResponse>> Update([FromBody] ManagementEmailUpdateDto Model)
		{
			Response<ManagementEmailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<ManagementEmailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/managementemail")]
        [Produces(typeof(Response<ManagementEmailResponse>))]
        [EndpointName("deletemanagementemail")]
        [EndpointSummary("you can delete managementemail using this API")]
        [EndpointDescription("you can delete managementemail using this API")]
        public async Task<Response<ManagementEmailResponse>> Delete([FromBody] ManagementEmailDeleteDto Model)
		{
			Response<ManagementEmailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<ManagementEmailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/managementemail")]
        [Produces(typeof(Response<ManagementEmailResponse>))]
        [EndpointName("getmanagementemail")]
        [EndpointSummary("you can use get data from managementemail API")]
        [EndpointDescription("you can use get data from managementemail API")]
        public async Task<Response<ManagementEmailResponse>> Get([FromQuery] ManagementEmailSelectDto Model)
		{
			Response<ManagementEmailResponse> Response = await Service.SelectAsync(Model);
			return new Response<ManagementEmailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/managementemailsingle")]
        [Produces(typeof(Response<ManagementEmailResponse>))]
        [EndpointName("getmanagementemailsingle")]
        [EndpointSummary("you can use get single data from managementemail API")]
        [EndpointDescription("you can use get single data from managementemail API")]
        public async Task<Response<ManagementEmailResponse>> GetSingle([FromQuery] ManagementEmailSelectDto Model)
		{
			Response<ManagementEmailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<ManagementEmailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}