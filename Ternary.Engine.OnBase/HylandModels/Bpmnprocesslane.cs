using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocesslane
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Lanenum { get; set; }

    public string? Lanename { get; set; }

    public long? Laneheight { get; set; }

    public long? Parentlanenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Filltype { get; set; }

    public long? Fillcolor1 { get; set; }

    public long? Fillcolor2 { get; set; }

    public long? Fillcolor3 { get; set; }

    public long? Flags { get; set; }

    public long? Stylenum { get; set; }
}
