using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workstationkey
{
    public long? Registernum { get; set; }

    public long? Appcontext { get; set; }

    public long? Institutionnum { get; set; }

    public string? Publickey { get; set; }
}
