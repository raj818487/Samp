using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SAMP.Domain.Custom;

namespace SAMP.WebAPI.Endpoints.AccReqEndpoints;

public class UpdateSpecific(IAccReqService accreqService) : EndpointBaseAsync
    .WithRequest<AccReqSpecific>
    .WithResult<Result<AccReq>>
{
    private readonly IAccReqService _accreqService = accreqService;

    /// <summary>
    /// Update AccReq
    /// </summary>
    [HttpPost("api/AccReq/updatespecific")]
    [SwaggerOperation(Summary = "Update specific fields of accreq", Description = "", OperationId = "AccReq.UpdateSpecific", Tags = ["AccReq"])]
    public override async Task<Result<AccReq>> HandleAsync(AccReqSpecific accreq, CancellationToken cancellationToken)
    {
        var result = await _accreqService.UpdateSpecificFields(accreq.AccReq.Id, accreq.AccReq, cancellationToken, accreq.Fields);
        return result;
    }
}