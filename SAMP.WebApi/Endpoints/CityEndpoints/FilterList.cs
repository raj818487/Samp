using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SAMP.WebAPI.Endpoints.CityEndpoints;

public class FilterList(ICityService cityService) : EndpointBaseAsync
    .WithRequest<QueryParameters<City>>
    .WithResult<Result<IEnumerable<City>>>
{
    private readonly ICityService _cityService = cityService;

    /// <summary>
    /// List all Citys
    /// </summary>
    [HttpPost("api/City/filterlist")]
    [SwaggerOperation(Summary = "filter citys", Description = "", OperationId = "City.FilterList", Tags = ["City"])]
    public override async Task<Result<IEnumerable<City>>> HandleAsync(QueryParameters<City> parameters, CancellationToken cancellationToken)
    {
        var result = await _cityService.GetFilterList(parameters, cancellationToken);
        return result;
    }
}