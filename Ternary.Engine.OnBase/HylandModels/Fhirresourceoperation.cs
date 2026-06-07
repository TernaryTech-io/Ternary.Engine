using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fhirresourceoperation
{
    public long Fhiroperationnum { get; set; }

    public long? Fhirepresourcenum { get; set; }

    public long? Operationtype { get; set; }

    public long? Flags { get; set; }
}
