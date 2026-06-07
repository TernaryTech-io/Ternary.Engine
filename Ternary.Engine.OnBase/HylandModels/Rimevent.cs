using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rimevent
{
    public long Rimeventnum { get; set; }

    public string? Rimeventname { get; set; }

    public string? Rimeventdesc { get; set; }

    public long? Newfolderstatus { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Eventdelay { get; set; }

    public long? Rimnotifyid { get; set; }
}
