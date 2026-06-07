using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Statusevaluator
{
    public long Evaluatornum { get; set; }

    public long? Evaluatortype { get; set; }

    public long? Valuenum { get; set; }

    public string? Evaluatorvalue { get; set; }

    public long? Ordinalposition { get; set; }

    public long? Sourcenodenum { get; set; }

    public long? Targetnodenum { get; set; }

    public long? Scanprocessxsqnum { get; set; }

    public long? Sourceside { get; set; }

    public long? Targetside { get; set; }
}
