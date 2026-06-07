using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmglobalmessage
{
    public long Fcmessagenum { get; set; }

    public long? Fcmsgtype { get; set; }

    public long? Fcswversion { get; set; }

    public string? Fctitle { get; set; }

    public string? Messagecontent { get; set; }

    public long? Fccolor { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }
}
