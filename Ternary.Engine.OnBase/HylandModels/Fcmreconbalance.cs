using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmreconbalance
{
    public long Fcreconbalancenum { get; set; }

    public string? Fctitle { get; set; }

    public string? Fcaccountcode { get; set; }

    public decimal? Fcbalance { get; set; }

    public DateTime? Fccreateddate { get; set; }

    public long? Fccreatedby { get; set; }

    public long? Fcparentbalancenum { get; set; }

    public long? Fcassociatedtypeid { get; set; }

    public long? Fcassociatedid { get; set; }

    public long? Flags { get; set; }

    public long? Fcsecondary { get; set; }

    public long? Fcmanualedit { get; set; }

    public long? Itemnum { get; set; }

    public DateTime? Fclastupdate { get; set; }

    public long? Fclastupdateby { get; set; }

    public long? Fccloseeventnum { get; set; }

    public long? Fcactive { get; set; }
}
