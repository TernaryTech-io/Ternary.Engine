using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Impparsefld
{
    public long Keytypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long Parsefilenum { get; set; }

    public long? Keysetnum { get; set; }

    public long? Keytypesetflags { get; set; }

    public long Ordernum { get; set; }

    public string Fieldtag { get; set; } = null!;

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Externaldataflag { get; set; }

    public string? Externaldataform { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public long? Insttype { get; set; }

    public long? Kwflags { get; set; }

    public long? Currencyformatnum { get; set; }

    public long? Fieldrequired { get; set; }
}
