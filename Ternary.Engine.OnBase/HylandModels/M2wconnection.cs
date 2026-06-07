using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wconnection
{
    public long Mwconnectionnum { get; set; }

    public long? Connectiontype { get; set; }

    public string? Connectionname { get; set; }

    public string? Connectstring { get; set; }

    public long? Mwapplicationnum { get; set; }
}
