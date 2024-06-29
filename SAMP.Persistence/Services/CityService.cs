
using SAMP.Application.Services;
using SAMP.Domain.Entities;

namespace SAMP.Persistence.Services;
public class CityService(DataContext _context) : ServiceBase<City>(_context), ICityService;