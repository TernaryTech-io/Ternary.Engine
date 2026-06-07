using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmcloseevent
{
    public long Fccloseeventnum { get; set; }

    public long? Fcclosemonth { get; set; }

    public long? Fccloseyear { get; set; }

    public long? Fcclosetype { get; set; }

    public DateTime? Fcdateclosed { get; set; }

    public long? Fccommentnum { get; set; }

    public long? Fcentitynum { get; set; }

    public DateTime? Fcprojectedclosedate { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Createdby { get; set; }

    public long? Closedbyusernum { get; set; }

    public long? Flags { get; set; }

    public string? Fctitle { get; set; }
}
