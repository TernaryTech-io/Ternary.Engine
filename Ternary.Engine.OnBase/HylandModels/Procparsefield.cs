using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Procparsefield
{
    public long Parsingmethod { get; set; }

    public long Fieldnum { get; set; }

    public long Keytypenum { get; set; }

    public long? Flags { get; set; }
}
