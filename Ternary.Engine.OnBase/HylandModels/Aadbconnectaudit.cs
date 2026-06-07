using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aadbconnectaudit
{
    public long? Masterauditnum { get; set; }

    public long? Aadbconnectnum { get; set; }

    public long? Aahostnum { get; set; }

    public string? Dbconnectioninfo { get; set; }

    public long? Dbconnectiontype { get; set; }

    public long? Aatenantnum { get; set; }

    public long? Flags { get; set; }
}
