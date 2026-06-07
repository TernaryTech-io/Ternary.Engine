using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplbidhistory
{
    public long Mkplbidhistnum { get; set; }

    public long? Mkplbidnum { get; set; }

    public long? Usernum { get; set; }

    public long? Historytype { get; set; }

    public string? Description { get; set; }

    public DateTime? Datecrated { get; set; }

    public long? Flags { get; set; }
}
