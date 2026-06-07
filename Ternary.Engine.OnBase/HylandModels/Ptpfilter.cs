using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ptpfilter
{
    public long Ptpfiltersnum { get; set; }

    public string? Ptpfiltertype { get; set; }

    public string? Ptpfiltervalue { get; set; }

    public long? Flags { get; set; }
}
