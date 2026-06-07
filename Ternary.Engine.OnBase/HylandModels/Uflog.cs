using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uflog
{
    public long Uflognum { get; set; }

    public long? Ufformnum { get; set; }

    public long? Formrevnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public string? Ufparentkey { get; set; }

    public string? Ufinstancekey { get; set; }

    public string? Uffieldkey { get; set; }

    public long? Action { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }
}
