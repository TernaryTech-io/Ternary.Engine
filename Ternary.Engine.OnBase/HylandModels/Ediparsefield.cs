using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ediparsefield
{
    public long? Parsingmethod { get; set; }

    public long Fieldid { get; set; }

    public string? Edifieldname { get; set; }

    public string Primaryxpath { get; set; } = null!;

    public string? Secondaryxpath { get; set; }

    public long? Flags { get; set; }
}
