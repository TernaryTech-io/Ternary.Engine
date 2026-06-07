using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Processstat
{
    public long? Batchnum { get; set; }

    public long? Institution { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Parsingmethod { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Totaldocuments { get; set; }

    public long? Totalunidentified { get; set; }

    public long? Totalpages { get; set; }

    public long? Errorflag { get; set; }

    public long? Atstepexecnum { get; set; }

    public long? Status { get; set; }

    public DateTime? Datestarted { get; set; }

    public long? Numsuccesses { get; set; }

    public long? Numfailures { get; set; }
}
