using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Qpdependency
{
    public string Jointablename { get; set; } = null!;

    public string Joincolumnname { get; set; } = null!;

    public string? Deptablename { get; set; }

    public string? Depcolumnname { get; set; }

    public long? Flags { get; set; }
}
