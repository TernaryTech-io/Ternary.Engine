using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmaskdef
{
    public long Maskdefid { get; set; }

    public string? Maskdefname { get; set; }

    public string? Description { get; set; }

    public string? Maskdefplaceholder { get; set; }

    public string? Maskdefmatch { get; set; }

    public long? Flags { get; set; }
}
