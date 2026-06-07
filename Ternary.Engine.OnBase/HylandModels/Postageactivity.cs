using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Postageactivity
{
    public long Pocustomernum { get; set; }

    public DateTime Activitydate { get; set; }

    public long? Postageused { get; set; }

    public string? Customerunit { get; set; }
}
