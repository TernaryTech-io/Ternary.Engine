using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ssrulegroup
{
    public long Ssrulegroupnum { get; set; }

    public long? Ssnum { get; set; }

    public long? Messageitnum { get; set; }

    public long? Attachitemtypenum { get; set; }

    public long? Messagesaveformat { get; set; }

    public long? Messageflags { get; set; }

    public long? Seqnum { get; set; }

    public long? Privacyflag { get; set; }

    public string? Ssruleformula { get; set; }

    public string? Ssmovefolderpath { get; set; }

    public string? Ssrulegroupname { get; set; }
}
