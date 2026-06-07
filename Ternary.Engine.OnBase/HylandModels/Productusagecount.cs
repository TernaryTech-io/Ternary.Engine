using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Productusagecount
{
    public long? Obproductid { get; set; }

    public DateTime? Lastlogon { get; set; }

    public long? Usagecount { get; set; }
}
