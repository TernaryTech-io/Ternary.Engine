using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Parsecontrol
{
    public long Controlnum { get; set; }

    public DateTime? Parsedate { get; set; }

    public string? Alternatefilename { get; set; }

    public string? Alternatepath { get; set; }

    public long? Autofolder { get; set; }

    public long? Batchfilenum { get; set; }

    public long? Dateoptions { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Testonly { get; set; }

    public long? Languagenum { get; set; }

    public long? Seqnum { get; set; }

    public string? Parsefilealias { get; set; }
}
