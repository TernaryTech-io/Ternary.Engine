using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Forgeviewable
{
    public long Forgeviewablenum { get; set; }

    public long? Forgeitemnum { get; set; }

    public long? Rootitemnum { get; set; }

    public long? Rootdocrevnum { get; set; }

    public long? Childitemvalue { get; set; }
}
