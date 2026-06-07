using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Subbarcodefield
{
    public long Scanfieldnum { get; set; }

    public long Keytypenum { get; set; }

    public long? Flags { get; set; }

    public long? Startposition { get; set; }

    public long? Fieldlength { get; set; }

    public string? Fielddelimiter { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Currmask { get; set; }

    public long? Decplaces { get; set; }

    public string? Decsymbol { get; set; }

    public long? Grpdigits { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currencyformatnum { get; set; }
}
