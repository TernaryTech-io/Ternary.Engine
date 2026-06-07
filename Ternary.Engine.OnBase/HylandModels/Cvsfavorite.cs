using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cvsfavorite
{
    public long Cvsfavoritenum { get; set; }

    public string? Cvsgroupname { get; set; }

    public string? Cvstitle { get; set; }

    public string? Cvsmoniker { get; set; }

    public long? Usernum { get; set; }
}
