using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtmessage
{
    public long Chtmessagenum { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Usernumfrom { get; set; }

    public long? Usernumto { get; set; }

    public string? Chtmessagetext { get; set; }

    public long? Flags { get; set; }

    public long? Messagestatus { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagenum { get; set; }

    public string? Chtmessagethread { get; set; }

    public long? Codingqueuenum { get; set; }

    public long? Statenum { get; set; }

    public long? Dfcynum { get; set; }
}
