using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Offlinedoc
{
    public long? Itemnum { get; set; }

    public long? Versionnum { get; set; }

    public DateTime? Synceddate { get; set; }

    public long? Synceduser { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }

    public string? Localinstanceid { get; set; }
}
