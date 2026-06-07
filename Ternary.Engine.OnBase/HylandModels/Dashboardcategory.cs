using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dashboardcategory
{
    public long Categorynum { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Iconnum { get; set; }

    public long? Flags { get; set; }
}
