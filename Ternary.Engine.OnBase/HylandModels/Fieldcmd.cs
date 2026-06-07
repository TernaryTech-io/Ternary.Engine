using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fieldcmd
{
    public long Fieldcmdnum { get; set; }

    public long Itemtypenum { get; set; }

    public long Pagenum { get; set; }

    public long? Foldernotdocflag { get; set; }

    public long? XposClickfield { get; set; }

    public long? YposClickfield { get; set; }

    public long? HeightClickfield { get; set; }

    public long? LengthClickfield { get; set; }

    public long? Dateflag { get; set; }

    public long? XposDatefield { get; set; }

    public long? YposDatefield { get; set; }

    public long? LengthDatefield { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public long? Flags { get; set; }

    public long? Currencyformatnum { get; set; }
}
