using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Kekcertificate
{
    public long Kekkekid { get; set; }

    public string Thumbprint { get; set; } = null!;

    public DateTimeOffset Createdate { get; set; }

    public bool Isactive { get; set; }
}
