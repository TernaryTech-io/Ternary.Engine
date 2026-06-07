using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmedidepsegment
{
    public long Rcmdepsegmentnum { get; set; }

    public string? Rcmdepsegmentname { get; set; }

    public long? Tablenumber { get; set; }

    public long? Columnnumber { get; set; }

    public long? Depcolumnnumber { get; set; }

    public string? Depvalue { get; set; }
}
