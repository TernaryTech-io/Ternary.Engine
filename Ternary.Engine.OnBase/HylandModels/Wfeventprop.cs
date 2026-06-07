using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfeventprop
{
    public long? Wfeventtypenum { get; set; }

    public string Propertyname { get; set; } = null!;

    public string? Propertyvalue { get; set; }

    public long? Propertytype { get; set; }

    public long? Flags { get; set; }

    public long Wfeventnum { get; set; }

    public long? Elementloc { get; set; }
}
