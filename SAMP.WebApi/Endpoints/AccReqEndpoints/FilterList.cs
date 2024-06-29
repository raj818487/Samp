using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SAMP.WebAPI.Endpoints.AccReqEndpoints;

public class FilterList(IAccReqService accreqService) : EndpointBaseAsync
    .WithRequest<QueryParameters<AccReq>>
    .WithResult<Result<IEnumerable<AccReq>>>
{
    private readonly IAccReqService _accreqService = accreqService;

    /// <summary>
    /// List all AccReqs
    /// </summary>
    [HttpPost("api/AccReq/filterlist")]
    [SwaggerOperation(Summary = "filter accreqs", Description = "", OperationId = "AccReq.FilterList", Tags = ["AccReq"])]
    public override async Task<Result<IEnumerable<AccReq>>> HandleAsync(QueryParameters<AccReq> parameters, CancellationToken cancellationToken)
    {
        var result = await _accreqService.GetFilterList(parameters, cancellationToken);
        return result;
    }
}