using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class MemCache
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public string? AbsoluteExpiration { get; set; }

    public string? AbsoluteExpirationRelativeToNow { get; set; }

    public string? SlidingExpiration { get; set; }
}
