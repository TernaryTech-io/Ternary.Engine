using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtxdiagnosis
{
    public long? Chtnum { get; set; }

    public long? Diagnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Diagnosistype { get; set; }

    public long? Diagnosispriority { get; set; }

    public DateTime? Diagnosisdatetime { get; set; }

    public long? Flags { get; set; }
}
