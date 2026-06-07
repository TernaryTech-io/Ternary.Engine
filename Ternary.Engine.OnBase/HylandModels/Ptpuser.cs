using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ptpuser
{
    public long? Usernum { get; set; }

    public string? Medrecnumber { get; set; }

    public string? Ptpuserpin { get; set; }

    public string? Ptpenrollmentkey { get; set; }

    public DateTime? Ptpaccessdate { get; set; }

    public long? Flags { get; set; }
}
