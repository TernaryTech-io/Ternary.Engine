using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7transcription
{
    public long Transitemtypenum { get; set; }

    public long? Headerlines { get; set; }

    public long? Footerlines { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Hl7destnum { get; set; }

    public long? Hl7flags { get; set; }

    public long? Hl7editsavemsgnum { get; set; }
}
