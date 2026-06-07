using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctracmessage
{
    public long Doctracmessagenum { get; set; }

    public long? Doctracmessagetype { get; set; }

    public string? Doctracmessage1 { get; set; }

    public long? Flags { get; set; }

    public string? Doctracmessagetitle { get; set; }

    public long? Institution { get; set; }

    public long? Severity { get; set; }
}
