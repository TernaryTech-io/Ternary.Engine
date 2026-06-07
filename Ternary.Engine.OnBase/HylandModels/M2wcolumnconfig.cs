using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wcolumnconfig
{
    public long Columnconfignum { get; set; }

    public long? Columntype { get; set; }

    public string? Querycolumnname { get; set; }

    public string? Mwcolumnwidth { get; set; }

    public string? Displayname { get; set; }

    public string? Tooltip { get; set; }

    public long? Sortdirection { get; set; }

    public long? Sortseqnum { get; set; }

    public long? Cellalignmentcode { get; set; }

    public long? Headeralignmentcode { get; set; }

    public string? Dataformatstring { get; set; }

    public long? Flags { get; set; }
}
