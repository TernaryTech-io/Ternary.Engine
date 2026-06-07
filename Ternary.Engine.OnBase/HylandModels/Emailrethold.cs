using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailrethold
{
    public long? Emailfoldernum { get; set; }

    public long? Emailnum { get; set; }

    public long? Emailholdtype { get; set; }

    public DateTime? Emailholddate { get; set; }

    public string? Emailholddesc { get; set; }

    public long? Usernum { get; set; }

    public long? Emailarchivenum { get; set; }

    public string? Emailitemdesc { get; set; }
}
