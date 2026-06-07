using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aitrainingjob
{
    public long Aitrainingjobnum { get; set; }

    public string? Jobname { get; set; }

    public long? Status { get; set; }

    public long? Aitrainquerynum { get; set; }

    public long? Formshint { get; set; }

    public long? Verifyitemnum { get; set; }

    public long? Percentagecomplete { get; set; }

    public long? Aitasktype { get; set; }

    public long? Aiclassifiertype { get; set; }

    public string? Aimodelfilepath { get; set; }
}
