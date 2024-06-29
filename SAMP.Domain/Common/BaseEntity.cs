using SAMP.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SAMP.Domain.Common;

public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Guid { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? DeletedAt { get; set; }
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
    public int? DeletedById { get; set; }
    [JsonIgnore]
   /* public Person CreatedBy { get; set; } = null!;
    [JsonIgnore]
    public Person UpdatedBy { get; set; } = null!;
    [JsonIgnore]
    public Person? DeletedBy { get; set; }*/

    // This is the shadow property used by EF Core
    private bool _isDeleted;
    // This is the property that will be mapped to the database
    public bool IsDeleted
    {
        get => DeletedAt.HasValue;
        set => _isDeleted = value;
    }
}