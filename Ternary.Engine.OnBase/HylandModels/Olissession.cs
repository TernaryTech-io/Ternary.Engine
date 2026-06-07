using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olissession
{
    public long Olissessionnum { get; set; }

    public DateTime? Olislogontime { get; set; }

    public string? Olispractid { get; set; }

    public string? Olispractfamname { get; set; }

    public string? Olispractgivenname { get; set; }

    public string? Olispractimidname { get; set; }

    public string? Olispractsuffix { get; set; }

    public string? Olispractprefix { get; set; }

    public string? Olisipracttypecode { get; set; }

    public string? Olisjurisdictionid { get; set; }

    public string? Olisjurisdictiontext { get; set; }

    public long? Status { get; set; }
}
