using SAMP.Domain.Common;

namespace MeraSatsang.Domain.Entities;
public abstract class LookupBase : BaseEntity
{
    public string EName { get; set; }
    public string GName { get; set; }
    public string HName { get; set; }
}
