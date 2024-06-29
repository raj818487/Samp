
using Ardalis.Result;
using SAMP.Application.DTOs.AccReqDto;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;

namespace SAMP.Application.Services;
public interface IAccReqService 
{
    Task<Result<IEnumerable<AccReq>>> GetAll(CancellationToken cancellationToken);
    Task<Result<AccReqResponseDto>> UpdateEntity(int id, AccReqUpdateDto entity, CancellationToken cancellationToken);
    Task<Result<AccReq>> Add(AccReq entity, CancellationToken cancellationToken);
    Task<Result<IEnumerable<AccReq>>> GetFilterList(QueryParameters<AccReq> parameters, CancellationToken cancellationToken);
    Task<Result<AccReq>> Update(AccReq entity, CancellationToken cancellationToken);

    Task<Result<AccReq>> UpdateSpecificFields(int id, AccReq entity, CancellationToken cancellationToken, params string[] propertiesToUpdate);


}