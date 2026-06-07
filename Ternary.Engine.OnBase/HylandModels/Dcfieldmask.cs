using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcfieldmask
{
    public long Dcfieldmasknum { get; set; }

    public string? Dcfieldmaskname { get; set; }

    public string? Maskchars { get; set; }

    public string? Staticchars { get; set; }

    public long? Flags { get; set; }
}
