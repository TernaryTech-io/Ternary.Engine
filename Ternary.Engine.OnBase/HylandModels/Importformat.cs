using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Importformat
{
    public long Importformatnum { get; set; }

    public string? Formatname { get; set; }

    public string? Companyname { get; set; }

    public long? Flags { get; set; }
}
