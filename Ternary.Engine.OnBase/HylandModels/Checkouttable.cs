using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Checkouttable
{
    public long Itemnum { get; set; }

    public long? Registernum { get; set; }

    public long? Usernum { get; set; }

    public string? Checkoutcomment { get; set; }

    public string? Checkoutpath { get; set; }

    public string? Guid { get; set; }

    public DateTime? Checkoutdate { get; set; }

    public long? Checkouttype { get; set; }
}
