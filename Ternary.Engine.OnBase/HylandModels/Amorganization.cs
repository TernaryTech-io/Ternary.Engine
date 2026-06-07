using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amorganization
{
    public long Amorgannum { get; set; }

    public string? Amorganname { get; set; }

    public string? Amorgantype { get; set; }

    public string? Organdescription { get; set; }

    public long? Flags { get; set; }
}
