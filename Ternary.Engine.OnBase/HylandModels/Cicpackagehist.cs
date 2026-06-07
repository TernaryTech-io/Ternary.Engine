using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cicpackagehist
{
    public long Cicpkghistnum { get; set; }

    public string? Cicpackageid { get; set; }

    public long? Cicpackagestatus { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Uploaddate { get; set; }

    public DateTime? Downloaddate { get; set; }

    public DateTime? Expdate { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Cicpackagename { get; set; }

    public long? Versionid { get; set; }

    public long? Itemnum { get; set; }
}
