using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medservice
{
    public long Medservicenum { get; set; }

    public string? Medservicecodehl7 { get; set; }

    public string? Medservicedesc { get; set; }
}
