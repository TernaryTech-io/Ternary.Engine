using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsitemdatum
{
    public long Itemnum { get; set; }

    public long? Imsdoctypeid { get; set; }

    public long? Imsdoctype { get; set; }

    public long? P2seqnum { get; set; }

    public long? Transeqnum { get; set; }

    public string? Appliedamtopid { get; set; }

    public string? Appliedamtjob { get; set; }

    public long? P2pocketseqnum { get; set; }

    public long? P2endofblock { get; set; }

    public long? Appliedamtindex { get; set; }

    public long? Imsbankid { get; set; }

    public string? Audittrail { get; set; }

    public long? Arcflag { get; set; }

    public string? Arcdata { get; set; }

    public string? Ocrscanline { get; set; }

    public string? Micrscanline { get; set; }

    public string? Imsrejectreason { get; set; }

    public long? Rejectjob { get; set; }

    public long? Ieitem { get; set; }

    public string? Arcreason { get; set; }
}
