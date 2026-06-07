using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usercheckout
{
    public long Usernum { get; set; }

    public string? Defcheckoutpath { get; set; }

    public long? Checkoutpref { get; set; }
}
