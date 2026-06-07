using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmnote
{
    public long Fcmnotenum { get; set; }

    public long? Sourcefieldnum { get; set; }

    public string? Entitytext { get; set; }

    public long? Flags { get; set; }
}
