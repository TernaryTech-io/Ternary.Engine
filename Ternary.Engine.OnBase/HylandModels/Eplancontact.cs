using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplancontact
{
    public long Epcontactnum { get; set; }

    public long? Epcontacttype { get; set; }

    public long? Epcontactvalue { get; set; }

    public string? Epcontactinfo { get; set; }
}
