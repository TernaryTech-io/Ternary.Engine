using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Virtualapp
{
    public long Virtualappnum { get; set; }

    public string? Virtualappname { get; set; }

    public string? Virtualappdesc { get; set; }

    public string? Vapassword { get; set; }

    public string? Vaversion { get; set; }

    public DateTime? Upgradedate { get; set; }
}
