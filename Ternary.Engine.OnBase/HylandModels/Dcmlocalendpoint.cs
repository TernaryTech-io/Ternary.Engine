using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcmlocalendpoint
{
    public long Localendpointnum { get; set; }

    public string? Localendpointname { get; set; }

    public string? Dcmipaddress { get; set; }

    public long? Dcmport { get; set; }

    public string? Dcmuri { get; set; }

    public long? Flags { get; set; }

    public long? Appentitynum { get; set; }
}
