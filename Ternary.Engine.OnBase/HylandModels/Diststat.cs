using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Diststat
{
    public long? Jobnum { get; set; }

    public long? Institution { get; set; }

    public long? Batchnum { get; set; }

    public string? Parsefilename { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Totalemails { get; set; }

    public long? Totalnotifications { get; set; }

    public long? Totalautocds { get; set; }

    public long? Totalprinted { get; set; }

    public long? Totalfaxed { get; set; }

    public string? Pqueuename { get; set; }

    public string? Distprocess { get; set; }

    public long? Atstepexecnum { get; set; }

    public long? Status { get; set; }
}
