using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prcopy
{
    public long Copynum { get; set; }

    public long? Itemnum { get; set; }

    public long? Requestingusernum { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Copyusernum { get; set; }

    public DateTime? Datecopied { get; set; }

    public string? Reasonforrequest { get; set; }

    public long? Delivmethodnum { get; set; }

    public string? Delivinstructions { get; set; }

    public string? Pruniqueid { get; set; }
}
