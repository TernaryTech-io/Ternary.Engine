using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sigfield
{
    public long Sigfieldnum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Formitemnum { get; set; }

    public string? Friendlyname { get; set; }

    public string? Sigfieldname { get; set; }
}
