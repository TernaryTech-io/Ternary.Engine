using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmcomponentstyle
{
    public long Rmcomponentstyleid { get; set; }

    public long? Rmcomponentid { get; set; }

    public string? Rmname { get; set; }

    public string? Value { get; set; }

    public long? Flags { get; set; }
}
