using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xmldipparsefld
{
    public long Parsefilenum { get; set; }

    public long Itemtypenum { get; set; }

    public long Keytypenum { get; set; }

    public string Xmltag { get; set; } = null!;

    public long? Keysetnum { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public long? Currencyformatnum { get; set; }

    public long? Fieldrequired { get; set; }
}
