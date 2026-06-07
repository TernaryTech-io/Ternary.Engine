using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcmremoteendpoint
{
    public long Remoteendpointnum { get; set; }

    public string? Remoteendpointname { get; set; }

    public string? Dcmipaddress { get; set; }

    public long? Dcmport { get; set; }

    public string? Dcmuri { get; set; }

    public long? Remappentitynum { get; set; }

    public long? Flags { get; set; }
}
