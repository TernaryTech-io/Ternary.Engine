using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Afpparsefield
{
    public long Parsefilenum { get; set; }

    public long Itemtypenum { get; set; }

    public long Keytypenum { get; set; }

    public string? Tagname { get; set; }

    public string? Tagvalue { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Usevalidation { get; set; }

    public string? Decsymbol { get; set; }

    public long? Decplaces { get; set; }

    public string? Grpsymbol { get; set; }

    public long? Grpdigits { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Onespace { get; set; }

    public string? Stripp { get; set; }

    public long? Keywordflag { get; set; }

    public long? Flags { get; set; }

    public long? Fieldid { get; set; }

    public long? Currencyformatnum { get; set; }
}
