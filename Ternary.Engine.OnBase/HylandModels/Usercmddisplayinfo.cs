using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usercmddisplayinfo
{
    public long Usercmdnum { get; set; }

    public string? Usercmdname { get; set; }

    public long? Smalliconnum { get; set; }

    public long? Largeiconnum { get; set; }

    public string? Helptext { get; set; }
}
