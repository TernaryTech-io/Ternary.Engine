using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityappsetting
{
    public long Etappsettingnum { get; set; }

    public long? Entitytypenum { get; set; }

    public string? Etsettingname { get; set; }

    public string? Etsettingvalue { get; set; }

    public long? Flags { get; set; }
}
