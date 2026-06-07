using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Transitionlog
{
    public long Transitionlognum { get; set; }

    public long? Sourcestepnum { get; set; }

    public long? Targetstepnum { get; set; }

    public long? Targetsetnum { get; set; }

    public long? Setaction { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Evaluatornum { get; set; }

    public long? Batchnum { get; set; }

    public long? Documentcount { get; set; }
}
