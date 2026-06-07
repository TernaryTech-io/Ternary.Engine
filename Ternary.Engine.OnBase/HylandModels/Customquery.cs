using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Customquery
{
    public long Cqnum { get; set; }

    public string? Cqname { get; set; }

    public long? Cqusedate { get; set; }

    public string? Cqinst { get; set; }

    public long? Cqfetchflag { get; set; }

    public long? Cqviewall { get; set; }

    public long? Cqsortresult { get; set; }

    public string? Searchstr { get; set; }

    public long? Setparam { get; set; }

    public long? Fromcolumn { get; set; }

    public long? Tocolumn { get; set; }

    public long? Textsearchflags { get; set; }

    public long? Cqflags { get; set; }

    public long? Usernum { get; set; }

    public string? Fromclause { get; set; }

    public string? Toclause { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Defaultdate { get; set; }

    public long? Cqusekeys { get; set; }

    public DateTime? Defaultdatevalue { get; set; }

    public string? Addselectclause { get; set; }

    public string? Whereclause { get; set; }

    public string? Sortclause { get; set; }
}
