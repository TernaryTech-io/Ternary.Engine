using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7rootinitializer
{
    public long Hl7rootinitnum { get; set; }

    public long? Hl7rootinitgrpnum { get; set; }

    public long? Schedtasknum { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Elapsedtime { get; set; }

    public long? Processingstep { get; set; }

    public long? Executionstatus { get; set; }

    public long? Recordcount { get; set; }

    public long? Flags { get; set; }
}
