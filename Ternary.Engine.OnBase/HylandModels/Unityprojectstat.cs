using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityprojectstat
{
    public long? Unityprojectnum { get; set; }

    public long? Projectversionnum { get; set; }

    public DateTime? Updatetime { get; set; }

    public long? Executioncount { get; set; }

    public long? Exceptioncount { get; set; }

    public long? Avgexecutiontime { get; set; }
}
