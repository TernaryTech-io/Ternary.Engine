using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Inigrouptable
{
    public long Usergroupnum { get; set; }

    public long Customernum { get; set; }

    public string Inisectionname { get; set; } = null!;

    public string Inientryname { get; set; } = null!;
}
