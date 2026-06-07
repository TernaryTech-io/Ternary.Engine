using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hxcfieldmapping
{
    public long Hxcprocessnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Fieldxmltag { get; set; }

    public string? Fieldxmlattrib { get; set; }

    public long? Dateformat { get; set; }

    public long? Dateseparator { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public long? Mappingtype { get; set; }

    public long? Mappingflags { get; set; }

    public string? Fieldxmlattribmatch { get; set; }

    public string? Fieldxmlattribkwvalue { get; set; }

    public long? Currmask { get; set; }
}
