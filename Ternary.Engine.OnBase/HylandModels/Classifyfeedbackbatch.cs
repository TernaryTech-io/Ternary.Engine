using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Classifyfeedbackbatch
{
    public long? Batchnum { get; set; }

    public long? Clsystemnum { get; set; }

    public DateTime? Starttime { get; set; }

    public long? Elapsedtime { get; set; }

    public long? Classified { get; set; }
}
