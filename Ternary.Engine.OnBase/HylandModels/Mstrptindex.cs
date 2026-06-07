using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mstrptindex
{
    public long Mpinum { get; set; }

    public string? Mpinumber { get; set; }

    public string? Ptfirstname { get; set; }

    public string? Ptlastname { get; set; }

    public DateTime? Ptdob { get; set; }

    public string? Ptssn { get; set; }

    public long? Ptsex { get; set; }

    public long? Primecarephysnum { get; set; }

    public string? Ptmiddlename { get; set; }

    public string? Ptspecialinst { get; set; }

    public DateTime? Ptdeceaseddate { get; set; }

    public long? Ptracenum { get; set; }

    public string? Hl7root { get; set; }
}
