using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Safetynet
{
    public long? Status { get; set; }

    public DateTime Processingdate { get; set; }

    public long Institution { get; set; }
}
