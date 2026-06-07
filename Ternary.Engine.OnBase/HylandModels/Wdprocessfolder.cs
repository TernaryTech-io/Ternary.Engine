using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wdprocessfolder
{
    public long Wdprocfoldernum { get; set; }

    public string? Procfoldername { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }
}
