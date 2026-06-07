using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Transactionxlog
{
    public long Transactionnum { get; set; }

    public string? Tmessage { get; set; }

    public long? Action { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Num { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Registernum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }
}
