using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mailxlog
{
    public long Mailactionnum { get; set; }

    public string? Tmessage { get; set; }

    public long? Actionnum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Num { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }
}
