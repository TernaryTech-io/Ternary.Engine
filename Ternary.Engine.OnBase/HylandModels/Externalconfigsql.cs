using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalconfigsql
{
    public long Externalconfignum { get; set; }

    public string? Connectstring { get; set; }

    public string? Sqlstmt { get; set; }

    public long? Flags { get; set; }

    public long? Obblobnum { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
