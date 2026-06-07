using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecvoidpurchaselog
{
    public long Ecpurchasenum { get; set; }

    public DateTime? Voiddate { get; set; }

    public long? Voidbyusernum { get; set; }

    public long? Flags { get; set; }

    public string? Voidreason { get; set; }

    public long? Voidbyecusernum { get; set; }
}
