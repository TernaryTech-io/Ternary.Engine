using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cvspolicy
{
    public long Cvspolicynum { get; set; }

    public string? Policyname { get; set; }

    public string? Cvspolicydesc { get; set; }

    public long? Priority { get; set; }

    public long? Flags { get; set; }
}
