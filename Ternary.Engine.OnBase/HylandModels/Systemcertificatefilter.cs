using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Systemcertificatefilter
{
    public long Syscertfilternum { get; set; }

    public long? Institution { get; set; }

    public long? Certificatefiltertype { get; set; }

    public string? Certificatefilter { get; set; }

    public long? Flags { get; set; }
}
