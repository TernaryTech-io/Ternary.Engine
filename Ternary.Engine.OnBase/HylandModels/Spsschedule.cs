using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Spsschedule
{
    public long? Spsconfignum { get; set; }

    public long? Days { get; set; }

    public long? Months { get; set; }

    public long? Years { get; set; }

    public string? Caml { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastrundate { get; set; }
}
