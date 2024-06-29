using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Image
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public string? OwnerId { get; set; }

    public int TypeId { get; set; }

    public string? Src { get; set; }

    public string? Caption { get; set; }

    public string? Description { get; set; }

    public int Height { get; set; }

    public int Width { get; set; }

    public virtual ImageType Type { get; set; } = null!;
}
