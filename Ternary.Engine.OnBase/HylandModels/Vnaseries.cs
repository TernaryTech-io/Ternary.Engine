using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnaseries
{
    public long Vnaseriesnum { get; set; }

    public long? Vnastudynum { get; set; }

    public string? Studyseriesuid { get; set; }

    public string? Modality { get; set; }

    public string? Seriesdescription { get; set; }

    public long? Origaenum { get; set; }

    public long? Dicomseriesnum { get; set; }

    public long Vnarevnum { get; set; }

    public long? Vnarevstatus { get; set; }

    public long? Vnarevreason { get; set; }

    public DateTime? Createdate { get; set; }
}
