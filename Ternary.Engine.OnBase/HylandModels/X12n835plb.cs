using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835plb
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Plb01provider { get; set; }

    public DateTime? Plb02date { get; set; }

    public string? Plb031reason { get; set; }

    public string? Plb032ref { get; set; }

    public decimal? Plb04amount { get; set; }

    public string? Plb051reason { get; set; }

    public string? Plb052ref { get; set; }

    public decimal? Plb06amount { get; set; }

    public string? Plb071reason { get; set; }

    public string? Plb072ref { get; set; }

    public decimal? Plb08amount { get; set; }

    public string? Plb091reason { get; set; }

    public string? Plb092ref { get; set; }

    public decimal? Plb10amount { get; set; }

    public string? Plb111reason { get; set; }

    public string? Plb112ref { get; set; }

    public decimal? Plb12amount { get; set; }

    public string? Plb131reason { get; set; }

    public string? Plb132ref { get; set; }

    public decimal? Plb14amount { get; set; }

    public long Plb835num { get; set; }
}
