using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimslockboxlog
{
    public long Lbimslognum { get; set; }

    public string? Messagetext { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Usernum { get; set; }

    public long? Lockboxnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Externalusernum { get; set; }

    public long? Customernum { get; set; }

    public long? Lbimslognumfk { get; set; }
}
