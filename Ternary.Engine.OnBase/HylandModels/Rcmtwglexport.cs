using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwglexport
{
    public long Rcmtwglexportnum { get; set; }

    public string? Rcmtwglexportname { get; set; }

    public string? Outputlocation { get; set; }

    public string? Archivelocation { get; set; }

    public string? Filenameformat { get; set; }

    public string? Fielddelimiter { get; set; }

    public string? Fieldseparator { get; set; }

    public long? Daysprior { get; set; }

    public long? Flags { get; set; }
}
