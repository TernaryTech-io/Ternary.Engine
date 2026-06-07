using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rimretstatus
{
    public long? Foldernum { get; set; }

    public long? Currentstatus { get; set; }

    public long? Prevstatus { get; set; }

    public DateTime? Entrytime { get; set; }

    public long? Eventtypenum { get; set; }

    public DateTime? Effectivedate { get; set; }

    public long? Effectivestatus { get; set; }

    public long? Flags { get; set; }

    public long? Retentionplannum { get; set; }
}
