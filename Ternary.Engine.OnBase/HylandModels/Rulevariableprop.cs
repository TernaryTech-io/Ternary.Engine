using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rulevariableprop
{
    public long Variablenum { get; set; }

    public string Propertyname { get; set; } = null!;

    public string? Propertyvalue { get; set; }

    public long? Propertytype { get; set; }
}
