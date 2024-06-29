
namespace SAMP.Domain.Common;

public class FilterModel
{
    public required string PropertyName { get; set; }
    public required string Operation { get; set; }
    public required string Value { get; set; }
}
