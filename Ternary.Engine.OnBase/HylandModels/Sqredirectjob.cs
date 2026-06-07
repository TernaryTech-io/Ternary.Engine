using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sqredirectjob
{
    public long Sqredirectjobnum { get; set; }

    public long? Queuenum { get; set; }

    public long? Targetqueuenum { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public string? Sqprocessname { get; set; }

    public long? Seqnum { get; set; }
}
