using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocesselevarmap
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Elementnum { get; set; }

    public string? Mappingpath { get; set; }

    public long? Variablenum { get; set; }

    public string? Variablepath { get; set; }

    public long? Flags { get; set; }
}
