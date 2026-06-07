using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pageid
{
    public long Pagenum { get; set; }

    public string? Idstring { get; set; }

    public long? Length { get; set; }

    public long? TwXpos { get; set; }

    public long? TwYpos { get; set; }
}
