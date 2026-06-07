using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsregparameter
{
    public long Tpsregnum { get; set; }

    public string Regparamname { get; set; } = null!;

    public string? Regparamvalue { get; set; }
}
