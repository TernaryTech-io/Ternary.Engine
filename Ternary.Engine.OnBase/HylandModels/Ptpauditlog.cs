using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ptpauditlog
{
    public long Ptpauditlognum { get; set; }

    public string? Ptplogcomment { get; set; }

    public string? Ptptype { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Medrecnumber { get; set; }
}
