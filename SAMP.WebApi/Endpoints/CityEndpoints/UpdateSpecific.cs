using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SAMP.Domain.Custom;

namespace SAMP.WebAPI.Endpoints.CityEndpoints;

public class UpdateSpecific(ICityService cityService) : EndpointBaseAsync
    .WithRequest<CitySpecific>
    .WithResult<Result<City>>
{
    private readonly ICityService _cityService = cityService;

    /// <summary>
    /// Update City
    /// </summary>
    [HttpPost("api/City/updatespecific")]
    [SwaggerOperation(Summary = "Update specific fields of city", Description = "", OperationId = "City.UpdateSpecific", Tags = ["City"])]
    public override async Task<Result<City>> HandleAsync(CitySpecific city, CancellationToken cancellationToken)
    {
        var result = await _cityService.UpdateSpecificFields(city.City.Id, city.City, cancellationToken, city.Fields);
        return result;
    }
}