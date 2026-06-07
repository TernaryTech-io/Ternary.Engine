using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtstat
{
    public long? Jobnum { get; set; }

    public long? Institution { get; set; }

    public long? Batchnum { get; set; }

    public string? Parsefilename { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Totalstmts { get; set; }

    public long? Totalcompleted { get; set; }

    public long? Totalcrippled { get; set; }

    public string? Pqueuename { get; set; }

    public long? Status { get; set; }

    public long? Atstepexecnum { get; set; }

    public long? Ppm { get; set; }
}
