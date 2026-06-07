using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocess
{
    public long Processnum { get; set; }

    public string? Bpmnprocessname { get; set; }

    public string? Description { get; set; }

    public long? Flags { get; set; }

    public long? Stylenum { get; set; }
}
