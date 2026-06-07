using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismsgitemtrnsfrm
{
    public long Eismsgitemtrfmnum { get; set; }

    public long? Eismsgitemtypenum { get; set; }

    public long? Targeteismsgitemtypenum { get; set; }

    public string? Xsltblobname { get; set; }

    public long? Xsltblobnum { get; set; }

    public long? Flags { get; set; }
}
