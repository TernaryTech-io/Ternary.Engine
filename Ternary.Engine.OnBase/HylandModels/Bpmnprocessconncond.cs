using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocessconncond
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Elementnum { get; set; }

    public long? Variablenum { get; set; }

    public string? Variablepath { get; set; }

    public long? Oper { get; set; }

    public string? Compareto { get; set; }

    public long? Col { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
