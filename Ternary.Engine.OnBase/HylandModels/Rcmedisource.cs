using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmedisource
{
    public long Rcmedisourcenum { get; set; }

    public string? Rcmedisourcename { get; set; }

    public long? Processlevel { get; set; }

    public long? Rcmediconfignum { get; set; }
}
