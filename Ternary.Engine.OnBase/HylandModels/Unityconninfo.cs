using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityconninfo
{
    public string? Unityconnname { get; set; }

    public long? Unityconntype { get; set; }

    public string? Unityconnstring { get; set; }

    public string? Unityconndesc { get; set; }

    public long Unityconnnum { get; set; }

    public long? Scopenum { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }
}
