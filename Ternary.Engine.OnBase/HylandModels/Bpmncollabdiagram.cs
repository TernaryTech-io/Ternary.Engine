using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmncollabdiagram
{
    public long Diagramnum { get; set; }

    public string? Diagramname { get; set; }

    public string? Description { get; set; }

    public long? Flags { get; set; }

    public long? Stylenum { get; set; }
}
