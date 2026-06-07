using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Systemlocale
{
    public long? Primarylcid { get; set; }

    public string? Localename { get; set; }

    public long? Flags { get; set; }
}
