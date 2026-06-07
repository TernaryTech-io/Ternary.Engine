using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repitemtimestamp
{
    public long Repitemnum { get; set; }

    public long Repitemtype { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Createdusernum { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifiedusernum { get; set; }

    public long? Flags { get; set; }
}
