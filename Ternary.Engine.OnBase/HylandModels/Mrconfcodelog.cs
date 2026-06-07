using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrconfcodelog
{
    public long Mrconfcodelognum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Confcodenum { get; set; }

    public long? Mpinum { get; set; }

    public long? Chtnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Messagetext { get; set; }

    public long? Registernum { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Flags { get; set; }
}
