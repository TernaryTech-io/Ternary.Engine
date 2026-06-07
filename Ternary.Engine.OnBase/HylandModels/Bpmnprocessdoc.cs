using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocessdoc
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Elementnum { get; set; }

    public long? Documentationtype { get; set; }

    public string? Documentation { get; set; }

    public long? Flags { get; set; }
}
