using System;
using System.Collections.Generic;
    
namespace SAMP.Domain.Entities;

public partial class Report
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Sql { get; set; } = null!;

    public int IsActive { get; set; }

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
