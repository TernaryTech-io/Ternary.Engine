using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aacomponentaudit
{
    public long? Masterauditnum { get; set; }

    public long? Aacomponentnum { get; set; }

    public long? Componenttype { get; set; }

    public string? Componentversion { get; set; }

    public long? Componentstatus { get; set; }

    public long? Aahostnum { get; set; }

    public string? Location { get; set; }

    public long? Locationtype { get; set; }

    public string? Primaryconfigfile { get; set; }

    public string? Secondaryconfigfile { get; set; }

    public DateTime? Firstdeployed { get; set; }

    public DateTime? Effectivefrom { get; set; }

    public long? Flags { get; set; }
}
