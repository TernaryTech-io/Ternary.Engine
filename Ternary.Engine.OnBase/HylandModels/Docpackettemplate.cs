using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpackettemplate
{
    public long Docpackettmplnum { get; set; }

    public string? Docpackettmplname { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Maxcontentsetitems { get; set; }

    public string? Headertext { get; set; }

    public string? Footertext { get; set; }

    public long? Watermarktype { get; set; }

    public string? Watermarktext { get; set; }

    public string? Watermarkfilepath { get; set; }

    public long? Watermarkitemnum { get; set; }

    public long? Privilegesflags { get; set; }

    public long? Versionid { get; set; }

    public long? Flags { get; set; }

    public long? Institution { get; set; }

    public long? Daterangekeytypenum { get; set; }

    public long? Sortkeytypenum { get; set; }

    public long? Disabled { get; set; }
}
