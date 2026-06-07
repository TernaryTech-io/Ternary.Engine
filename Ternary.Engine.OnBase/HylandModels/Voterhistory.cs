using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Voterhistory
{
    public long? Voternum { get; set; }

    public long? Electionnum { get; set; }

    public string? Precinctcode { get; set; }

    public long? Locationnum { get; set; }

    public long? Partynum { get; set; }

    public long? Issueonly { get; set; }

    public long? Signatureitemnum { get; set; }
}
