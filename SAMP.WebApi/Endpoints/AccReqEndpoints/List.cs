using Ardalis.ApiEndpoints;
using Ardalis.Result;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SAMP.Application.DTOs.AccReqDto;
using SAMP.Application.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SAMP.Persistence;
using Microsoft.EntityFrameworkCore;

namespace SAMP.WebAPI.Endpoints.AccReqEndpoints
{
    public class List : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<Result<AccReqResponseDto>>
    {
        private readonly DataContext _context;
        private readonly IAccReqService _accreqService;
        private readonly IMapper _mapper;

        public List(IAccReqService accreqService, IMapper mapper, DataContext context)
        {
            _accreqService = accreqService;
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        /// List all AccReqs
        /// </summary>
        [HttpGet("api/AccReq/list")]
        [SwaggerOperation(
            Summary = "List all accreqs",
            Description = "Retrieves a list of all accreqs",
            OperationId = "AccReq.List",
            Tags = new[] { "AccReq" }
        )]
        public override async Task<ActionResult<Result<AccReqResponseDto>>> HandleAsync(CancellationToken cancellationToken = default)
        {

            var result = await _accreqService.GetAll(cancellationToken);

            

            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            var dtos = _mapper.Map<IEnumerable<AccReqResponseDto>>(result.Value);

            return Ok(Result<IEnumerable<AccReqResponseDto>>.Success(dtos));
        }
    }
}
