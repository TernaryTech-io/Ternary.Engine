using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmhpiexport
{
    public long Rcmhpiexportnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public string? Outputlocation { get; set; }

    public string? Archivelocation { get; set; }

    public string? Filenameformat { get; set; }

    public string? Rcmhpiexportname { get; set; }

    public long? Flags { get; set; }
}
