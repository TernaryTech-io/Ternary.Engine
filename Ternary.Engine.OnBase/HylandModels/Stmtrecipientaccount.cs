using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtrecipientaccount
{
    public long Recipientacctnum { get; set; }

    public long? Recipientnum { get; set; }

    public long? Distprocessnum { get; set; }

    public string? Idkeywords { get; set; }

    public long? Flags { get; set; }

    public long? Processclassnum { get; set; }
}
