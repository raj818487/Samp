using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

 namespace SAMP.WebAPI.Endpoints.CityEndpoints;
 
 public class List(ICityService cityService) : EndpointBaseAsync
     .WithoutRequest
     .WithResult<Result<IEnumerable<City>>>
 {
     private readonly ICityService _cityService = cityService;
 
     /// <summary>
     /// List all Citys
     /// </summary>
     [HttpPost("api/City/list")]
     [SwaggerOperation(Summary = "List all citys", Description = "", OperationId = "City.List", Tags = ["City"])]
     public override async Task<Result<IEnumerable<City>>> HandleAsync(CancellationToken cancellationToken)
     {
         var result = await _cityService.GetAll(cancellationToken);
         return result;
     }
 }