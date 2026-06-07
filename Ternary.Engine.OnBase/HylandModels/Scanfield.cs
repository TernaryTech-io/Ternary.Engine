using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanfield
{
    public long Scanfieldnum { get; set; }

    public string? Scanfieldname { get; set; }

    public long? Barcodetype { get; set; }

    public string? Datamatch { get; set; }

    public long? Deltax { get; set; }

    public long? Deltay { get; set; }

    public long? Expect { get; set; }

    public long? Keysetnum { get; set; }

    public long? Keytypeflag { get; set; }

    public long? Keytypenum { get; set; }

    public long? Keywordflag { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Resolution { get; set; }

    public long? Topx { get; set; }

    public long? Topy { get; set; }

    public long? Externaldataflag { get; set; }

    public string? Externaldataform { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Currmask { get; set; }

    public long? Decplaces { get; set; }

    public string? Decsymbol { get; set; }

    public long? Grpdigits { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Minoccurrences { get; set; }

    public long? Currencyformatnum { get; set; }

    public long? Unityopernum { get; set; }
}
