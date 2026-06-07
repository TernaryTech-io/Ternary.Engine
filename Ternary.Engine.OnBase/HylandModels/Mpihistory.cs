using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpihistory
{
    public long? Mpinum { get; set; }

    public string? Prevmpinumber { get; set; }

    public string? Actionname { get; set; }

    public string? Hl7root { get; set; }
}
