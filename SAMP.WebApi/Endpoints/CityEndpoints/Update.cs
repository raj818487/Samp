using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SAMP.WebAPI.Endpoints.CityEndpoints;

public class Update(ICityService cityService) : EndpointBaseAsync
    .WithRequest<City>
    .WithResult<Result<City>>
{
    private readonly ICityService _cityService = cityService;

    /// <summary>
    /// Update City
    /// </summary>
    [HttpPost("api/City/update")]
    [SwaggerOperation(Summary = "Update city", Description = "", OperationId = "City.Update", Tags = ["City"])]
    public override async Task<Result<City>> HandleAsync(City city, CancellationToken cancellationToken)
    {
        var result = await _cityService.Update(city, cancellationToken);
        return result;
    }
}