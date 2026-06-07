using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmguarexport
{
    public long Rcmguarexportnum { get; set; }

    public string? Rcmguarexportname { get; set; }

    public long? Rcmqueuenum { get; set; }

    public long? Destqueuenum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public string? Outputlocation { get; set; }

    public string? Archivelocation { get; set; }

    public string? Filenameformat { get; set; }

    public long? Exporttype { get; set; }

    public long? Flags { get; set; }
}
