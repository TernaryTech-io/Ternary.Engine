using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mprequest
{
    public long Mprequestnum { get; set; }

    public long? Requesttype { get; set; }

    public string? Requestdetail { get; set; }

    public DateTime? Createdate { get; set; }
}
