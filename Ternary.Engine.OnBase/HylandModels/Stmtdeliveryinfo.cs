using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtdeliveryinfo
{
    public long Stmtdelivinfonum { get; set; }

    public string? Stmtdelivinfoname { get; set; }

    public string? Longsubject { get; set; }

    public string? Longmessage { get; set; }

    public long? Stmtdelinfoflags { get; set; }

    public long? Institution { get; set; }

    public long? Attachitemnum1 { get; set; }

    public long? Attachitemnum2 { get; set; }

    public long? Attachitemnum3 { get; set; }

    public string? Attachname1 { get; set; }

    public string? Attachname2 { get; set; }

    public string? Attachname3 { get; set; }

    public long? Attachformat1 { get; set; }

    public long? Attachformat2 { get; set; }

    public long? Attachformat3 { get; set; }

    public string? Maskchar { get; set; }
}
