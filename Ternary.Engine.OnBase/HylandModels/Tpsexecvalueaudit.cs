using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsexecvalueaudit
{
    public long? Tpsengineexecnum { get; set; }

    public long? Tpsexecdir { get; set; }

    public string? Parametername { get; set; }

    public string? Tpsparametervalue { get; set; }
}
