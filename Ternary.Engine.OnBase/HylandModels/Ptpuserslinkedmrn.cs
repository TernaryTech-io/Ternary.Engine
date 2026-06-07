using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ptpuserslinkedmrn
{
    public long? Usernum { get; set; }

    public string? Medrecnumber { get; set; }

    public DateTime? Linkeddate { get; set; }

    public DateTime? Expiredate { get; set; }

    public string? Ptprelationship { get; set; }

    public long? Flags { get; set; }
}
