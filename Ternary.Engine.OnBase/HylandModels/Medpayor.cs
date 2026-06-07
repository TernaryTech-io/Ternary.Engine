using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medpayor
{
    public long Medpayornum { get; set; }

    public string? Medpayorcodehl7 { get; set; }

    public string? Medpayordesc { get; set; }
}
