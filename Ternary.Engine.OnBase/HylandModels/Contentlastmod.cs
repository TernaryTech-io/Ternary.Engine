using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Contentlastmod
{
    public long Ctlastmodifiednum { get; set; }

    public long? Objectid { get; set; }

    public long? Objecttype { get; set; }

    public long? Parentlastmodid { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Ctsourcenum { get; set; }
}
