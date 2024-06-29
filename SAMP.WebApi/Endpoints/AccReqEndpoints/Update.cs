using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SAMP.Application.DTOs.AccReqDto;

namespace SAMP.WebAPI.Endpoints.AccReqEndpoints;
public class Update : EndpointBaseAsync
    .WithRequest<AccReqUpdateDto>
    .WithResult<Result<AccReqResponseDto>>
{
    private readonly IAccReqService _accreqService;

    public Update(IAccReqService accreqService)
    {
        _accreqService = accreqService;
    }

    [HttpPost("api/AccReq/update")]
    [SwaggerOperation(Summary = "Update AccReq", Description = "Update an existing AccReq entity", OperationId = "AccReq.Update", Tags = ["AccReq"])]
    public override async Task<Result<AccReqResponseDto>> HandleAsync(AccReqUpdateDto accreqUpdateDto, CancellationToken cancellationToken)
    {
        var result = await _accreqService.UpdateEntity(accreqUpdateDto.Id, accreqUpdateDto, cancellationToken);

        return result;
    }
}


//{
//  "id": 8,

//  "firstName": "RAJJJJJJJJJJJJJJ",
//  "middleName": "RAJJJJJJJJJJ",
//  "lastName": "RAJJJJJJJJJJ",
//  "gender": "F",
//  "age": 50,
//  "primaryMobile": "89898988989",

//  "gentsCount": 50,
//  "ladiesCount": 50,
//  "childrenCount": 50,

//  "expCheckInTime": "2024-06-29T05:36:57.871Z",
//  "expCheckOutTime": "2024-06-29T05:36:57.871Z"

//}