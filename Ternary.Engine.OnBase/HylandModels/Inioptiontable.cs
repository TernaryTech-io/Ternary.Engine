using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Inioptiontable
{
    public long Registernum { get; set; }

    public long Usernum { get; set; }

    public string Inisectionname { get; set; } = null!;

    public string Inientryname { get; set; } = null!;

    public long? Inioptionnum { get; set; }

    public string? Inivalue { get; set; }
}
