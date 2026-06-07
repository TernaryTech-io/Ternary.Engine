using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufstring
{
    public long Ufstringnum { get; set; }

    public long? Exportlcid { get; set; }

    public string? Ufstringvalue { get; set; }

    public long? Flags { get; set; }
}
