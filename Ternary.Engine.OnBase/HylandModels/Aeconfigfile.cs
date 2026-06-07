using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aeconfigfile
{
    public long Aeconfignum { get; set; }

    public string? Aeconfigname { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }
}
