using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uipref
{
    public long Uiprefnum { get; set; }

    public long? Facilitynum { get; set; }

    public long? Dptnum { get; set; }

    public long? Deftabnum { get; set; }

    public long? Chtrevnum { get; set; }

    public DateTime? Revisiondate { get; set; }

    public long? Contextid { get; set; }
}
