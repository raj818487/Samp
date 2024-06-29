using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SAMP.WebAPI.Endpoints.CityEndpoints;

public class Add(ICityService cityService) : EndpointBaseAsync
    .WithRequest<City>
    .WithResult<Result<City>>
{
    private readonly ICityService _cityService = cityService;

    /// <summary>
    /// Add City
    /// </summary>
    [HttpPost("api/City/add")]
    [SwaggerOperation(Summary = "Add city", Description = "", OperationId = "City.Add", Tags = ["City"])]
    public override async Task<Result<City>> HandleAsync(City city,CancellationToken cancellationToken)
    {
        var result = await _cityService.Add(city, cancellationToken);
        return result;
    }
}