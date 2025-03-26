namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class ManagementDetailController : ControllerBase
	{
		readonly IManagementDetailService Service;
		public ManagementDetailController(IManagementDetailService service)
		{
			Service = service;
		}

		[HttpPost]
		[Route("api/managementdetail")]
		[Produces(typeof(Response<ManagementDetailResponse>))]
		[EndpointName("managementdetail")]
		[EndpointSummary("this is summary of create a new managementdetail")]
		[EndpointDescription("this is description of create a new managementdetail")]
		public async Task<Response<ManagementDetailResponse>> Create([FromBody] ManagementDetailRegisterDto Model)
		{
			Response<ManagementDetailResponse> Response = await Service.InsertAsync(Model);
			return new Response<ManagementDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/managementdetail")]
		public async Task<Response<ManagementDetailResponse>> Update([FromBody] ManagementDetailUpdateDto Model)
		{
			Response<ManagementDetailResponse> Response = await Service.UpdateAsync(Model);
			return new Response<ManagementDetailResponse>
			{
                ResponseData = Response.ResponseData
            };
		}

		[HttpDelete]
		[Route("api/managementdetail")]
		public async Task<Response<ManagementDetailResponse>> Delete([FromBody] ManagementDetailDeleteDto Model)
		{
			Response<ManagementDetailResponse> Response = await Service.DeleteAsync(Model);
			return new Response<ManagementDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/managementdetail")]
        [Produces(typeof(Response<ManagementDetailResponse>))]
        [EndpointName("getmanagementdetail")]
        [EndpointSummary("you can use get data from managementdetail API")]
        [EndpointDescription("you can use get data from managementdetail API")]
        public async Task<Response<ManagementDetailResponse>> Get([FromQuery] ManagementDetailSelectDto Model)
		{
			Response<ManagementDetailResponse> Response = await Service.SelectAsync(Model);
			return new Response<ManagementDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/managementdetailsingle")]
		public async Task<Response<ManagementDetailResponse>> GetSingle([FromQuery] ManagementDetailSelectDto Model)
		{
			Response<ManagementDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<ManagementDetailResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}