namespace Universe.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Routing;

	[ApiController]
	public class AbilityController : ControllerBase
	{
		readonly IAbilityService Service;
		public AbilityController(IAbilityService service)
		{
			Service = service;
		}

        [HttpPost]
        [Route("api/ability")]
		[Produces(typeof(Response<AbilityResponse>))]
		[EndpointName("createability")]
		[EndpointSummary("you can create ability using this API")]
		[EndpointDescription("you can create ability using this API")]
		public async Task<Response<AbilityResponse>> Create([FromBody] AbilityRegisterDto Model)
		{
			Response<AbilityResponse> Response = await Service.InsertAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/ability")]
        [Produces(typeof(Response<AbilityResponse>))]
        [EndpointName("updateability")]
        [EndpointSummary("you can use for update using ability API")]
        [EndpointDescription("you can use for update using ability API")]
        public async Task<Response<AbilityResponse>> Update([FromBody] AbilityUpdateDto Model)
		{
			Response<AbilityResponse> Response = await Service.UpdateAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/ability")]
        [Produces(typeof(Response<AbilityResponse>))]
        //[EndpointName("deleteability")]
        [EndpointSummary("you can delete using ability API")]
        [EndpointDescription("you can delete using ability API")]
        public async Task<Response<AbilityResponse>> Delete([FromBody] AbilityDeleteDto Model)
		{
			Response<AbilityResponse> Response = await Service.DeleteAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/ability")]
        [Produces(typeof(Response<AbilityResponse>))]
        [EndpointName("getability")]
        [EndpointSummary("you can use get data from ability API")]
        [EndpointDescription("you can use get data from ability API")]
        public async Task<Response<AbilityResponse>> Get([FromQuery] AbilitySelectDto Model)
		{
			Response<AbilityResponse> Response = await Service.SelectAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}

		[HttpGet]
		[Route("api/abilitysingle")]
        [Produces(typeof(Response<AbilityResponse>))]
        [EndpointName("getabilitysingle")]
        [EndpointSummary("use this for get single data using this API")]
        [EndpointDescription("use this for get single data using this API")]
        public async Task<Response<AbilityResponse>> GetSingle([FromQuery] AbilitySelectDto Model)
		{
			Response<AbilityResponse> Response = await Service.SelectSingleAsync(Model);
			return new Response<AbilityResponse>
			{
				ResponseCollection = Response.ResponseCollection
			};
		}
	}
}