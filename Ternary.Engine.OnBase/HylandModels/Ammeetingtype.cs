using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammeetingtype
{
    public long Ammeetingtypenum { get; set; }

    public string? Ammeetingtypename { get; set; }

    public long? Amorgannum { get; set; }

    public long? Agendaoutlinenum { get; set; }

    public long? Flags { get; set; }

    public string? Amdisplayname { get; set; }

    public long? Publishflags { get; set; }

    public long? Templatenum { get; set; }

    public long? Revisionnum { get; set; }

    public string? Defaultmeetingname { get; set; }

    public string? Defaultmeetingloc { get; set; }

    public string? Defaultmeetingorgan { get; set; }

    public DateTime? Defaultmeetingtime { get; set; }

    public long? Defaultnextmtgtypenum { get; set; }
}
