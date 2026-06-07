using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Atitiprocstat
{
    public long? Atprogramnum { get; set; }

    public long? Atstepnum { get; set; }

    public long? Atstepgroupnum { get; set; }

    public long? Atstepexecnum { get; set; }

    public long? Status { get; set; }

    public long? Institution { get; set; }

    public long? Steptype { get; set; }

    public long? Promptoption { get; set; }

    public long? Responsenum { get; set; }

    public long? Freeitems { get; set; }

    public long? Missingitems { get; set; }

    public long? Batchnum { get; set; }

    public string? Userprompt { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Action { get; set; }
}
