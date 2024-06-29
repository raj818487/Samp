
using Ardalis.Result;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SAMP.Application.DTOs.AccReqDto;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;

namespace SAMP.Persistence.Services;
public class AccReqService : IAccReqService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public AccReqService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<Result<AccReq>> Add(AccReq entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Delete(AccReq entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<IEnumerable<AccReq>>> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _context.Set<AccReq>()
                                       .Include(c => c.City)
                                       .ThenInclude(ct => ct.State)
                                       .ThenInclude(a => a.Country).Include(s=> s.Status).Include(rt=> rt.ReqTransMode)
                                       .ToListAsync(cancellationToken);
            return Result<IEnumerable<AccReq>>.Success(result);
        }
        catch (Exception ex)
        {
            return Result<IEnumerable<AccReq>>.Error(new[] { ex.Message });
        }
    }

    public Task<AccReq> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Result<IEnumerable<AccReq>>> GetFilterList(QueryParameters<AccReq> parameters, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Result<AccReq>> Update(AccReq entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    //public async Task<Result<AccReqResponseDto>> UpdateEntity(int id, AccReqUpdateDto dto, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var existingEntity = await _context.Set<AccReq>()
    //                                           .Include(c => c.City)
    //                                           .ThenInclude(ct => ct.State)
    //                                           .ThenInclude(a => a.Country)
    //                                           .Include(s => s.Status)
    //                                           .Include(rt => rt.ReqTransMode)
    //                                           .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

    //        if (existingEntity == null)
    //        {
    //            return Result<AccReqResponseDto>.NotFound();
    //        }

    //        _mapper.Map(dto, existingEntity);
    //        await _context.SaveChangesAsync(cancellationToken);

    //        var responseDto = _mapper.Map<AccReqResponseDto>(existingEntity);
    //        return Result<AccReqResponseDto>.Success(responseDto);
    //    }
    //    catch (Exception ex)
    //    {
    //        return Result<AccReqResponseDto>.Error(new[] { ex.Message });
    //    }
    //}

    public async Task<Result<AccReqResponseDto>> UpdateEntity(int id, AccReqUpdateDto dto, CancellationToken cancellationToken)
    {
        try
        {
            var existingEntity = await _context.Set<AccReq>()
                                               .Include(c => c.City)
                                               .ThenInclude(ct => ct.State)
                                               .ThenInclude(a => a.Country)
                                               .Include(s => s.Status)
                                               .Include(rt => rt.ReqTransMode)
                                               .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (existingEntity == null)
            {
                return Result<AccReqResponseDto>.NotFound();
            }

            _mapper.Map(dto, existingEntity);
            existingEntity.ModifiedAt = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

            await _context.SaveChangesAsync(cancellationToken);

            var responseDto = _mapper.Map<AccReqResponseDto>(existingEntity);
            return Result<AccReqResponseDto>.Success(responseDto);
        }
        catch (DbUpdateConcurrencyException ex)
        {
            // Log detailed exception
            Console.WriteLine($"Concurrency error: {ex.Message}\nInner exception: {ex.InnerException?.Message}");
            return Result<AccReqResponseDto>.Error(new[] { "Concurrency error: The entity has been modified by another process." });
        }
        catch (DbUpdateException ex)
        {
            // Log detailed exception
            Console.WriteLine($"Update error: {ex.Message}\nInner exception: {ex.InnerException?.Message}");
            return Result<AccReqResponseDto>.Error(new[] { "Update error: There was an issue saving changes to the database." });
        }
        catch (Exception ex)
        {
            // Log detailed exception
            Console.WriteLine($"General error: {ex.Message}\nInner exception: {ex.InnerException?.Message}");
            return Result<AccReqResponseDto>.Error(new[] { "An error occurred while saving the entity changes." });
        }
    }


    public Task<Result<AccReq>> UpdateSpecificFields(int id, AccReq entity, CancellationToken cancellationToken, params string[] propertiesToUpdate)
    {
        throw new NotImplementedException();
    }
}