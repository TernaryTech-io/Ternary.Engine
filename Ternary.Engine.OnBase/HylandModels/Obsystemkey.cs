using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obsystemkey
{
    public string? Obkeypart { get; set; }

    public string? Obkeypart2 { get; set; }

    public string? Keycheckstring { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }

    public string? Keksalt { get; set; }

    public long? Kekhashtype { get; set; }
}
