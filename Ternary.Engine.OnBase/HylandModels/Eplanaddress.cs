using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanaddress
{
    public long Epaddressnum { get; set; }

    public string? Epaddress1 { get; set; }

    public string? Epaddress2 { get; set; }

    public string? Epcity { get; set; }

    public string? Epstate { get; set; }

    public string? Epzipcode { get; set; }

    public string? Epcountry { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Flags { get; set; }

    public string? Epaddressnumber { get; set; }
}
