using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mppatientaccess
{
    public long? Mpinum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Accessexpiredate { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Accesstype { get; set; }

    public string? Accessrequestreason { get; set; }

    public long? Chtaccreasonnum { get; set; }

    public long? Grantingusernum { get; set; }
}
