using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itxrefkeytype
{
    public long Keytypenum { get; set; }

    public long Xrefitemtypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Keysetnum { get; set; }

    public long? Keytypesetflags { get; set; }

    public long? Dblclkflag { get; set; }

    public long? Onespace { get; set; }

    public long? Allowed { get; set; }

    public string? Stripp { get; set; }

    public long? Xreftypeflag { get; set; }

    public long? Xrefleft { get; set; }

    public long? Xrefright { get; set; }

    public long? Xreftop { get; set; }

    public long? Xrefbottom { get; set; }

    public long? Itemorfolder { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public long? Externaldataflag { get; set; }

    public string? Externaldataform { get; set; }
}
