using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismsgitemtype
{
    public long Eismsgitemtypenum { get; set; }

    public string? Eismsgitemtypename { get; set; }

    public string? Description { get; set; }

    public long? Xsdblobnum { get; set; }

    public string? Xsdname { get; set; }

    public string? Xsdrootname { get; set; }

    public long? Formattype { get; set; }

    public string? Stylesheetname { get; set; }

    public long? Stylesheetblobnum { get; set; }

    public long? Archiveafternumsecs { get; set; }

    public long? Deleteafternumsecs { get; set; }

    public long? Purgeafternumsecs { get; set; }

    public string? Autonamestring { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public long? Eisserliznrulenum { get; set; }

    public long? Eisofframpnum { get; set; }
}
