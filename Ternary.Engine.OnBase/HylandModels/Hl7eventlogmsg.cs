using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7eventlogmsg
{
    public long? Hl7eventlognum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Status { get; set; }

    public string? Hl7messagetext { get; set; }

    public long? Flags { get; set; }
}
