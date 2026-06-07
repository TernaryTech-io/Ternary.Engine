using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raauditlevel
{
    public long? Raclaimnum { get; set; }

    public long? Ralevel { get; set; }

    public DateTime? Respondenddate { get; set; }

    public DateTime? Responddate { get; set; }

    public DateTime? Decisionenddate { get; set; }

    public DateTime? Decisiondate { get; set; }

    public DateTime? Stoprecoupenddate { get; set; }

    public long? Seqnum { get; set; }

    public long? Determinationstatus { get; set; }

    public long? Flags { get; set; }
}
