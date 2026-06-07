using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismsgitemarchive
{
    public long? Eismsgitemnum { get; set; }

    public long? Eismsgitemtypenum { get; set; }

    public long? Trnsfrmsrceismsgitemnum { get; set; }

    public long? Datablobnum { get; set; }

    public long? Responseblobnum { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Itemname { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }
}
