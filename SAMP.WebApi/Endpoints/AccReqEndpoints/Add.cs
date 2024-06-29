using Ardalis.ApiEndpoints;
using Ardalis.Result;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SAMP.Application.DTOs.AccReqDto;
using SAMP.Application.Services;
using System.Threading;
using System.Threading.Tasks;
using SAMP.Domain.Entities;

namespace SAMP.WebAPI.Endpoints.AccReqEndpoints
{
    public class Add : EndpointBaseAsync
        .WithRequest<AccReqCreateDto>
        .WithResult<Result<AccReqResponseDto>>
    {
        private readonly IAccReqService _accreqService;
        private readonly IMapper _mapper;

        public Add(IAccReqService accreqService, IMapper mapper)
        {
            _accreqService = accreqService;
            _mapper = mapper;
        }

        /// <summary>
        /// Add a new AccReq
        /// </summary>
        [HttpPost("api/AccReq")]
        [SwaggerOperation(
            Summary = "Add a new accreq",
            Description = "Creates a new accreq",
            OperationId = "AccReq.Add",
            Tags = new[] { "AccReq" }
        )]
        public override async Task<Result<AccReqResponseDto>> HandleAsync(AccReqCreateDto request, CancellationToken cancellationToken = default)
        {
            var mappingreq = _mapper.Map<AccReq>(request);

            var result = await _accreqService.Add(mappingreq, cancellationToken);

           

            var dto = _mapper.Map<AccReqResponseDto>(result.Value);

            return Result<AccReqResponseDto>.Success(dto);
        }
    }
}
