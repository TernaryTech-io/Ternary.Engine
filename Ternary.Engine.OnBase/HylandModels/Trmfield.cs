using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Trmfield
{
    public long Trmfieldnum { get; set; }

    public long? Fieldcmdnum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Length { get; set; }

    public long? Height { get; set; }

    public long? TwXpos { get; set; }

    public long? TwYpos { get; set; }

    public long? Externaldataflag { get; set; }

    public string? Externaldataform { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Onespace { get; set; }

    public string? Stripp { get; set; }

    public long? Xreftypeflag { get; set; }

    public long? Currencyformatnum { get; set; }
}
