using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpixaddress
{
    public long? Mpinum { get; set; }

    public long? Status { get; set; }

    public long? Ptaddresstype { get; set; }

    public string? Ptstreet { get; set; }

    public string? Ptcity { get; set; }

    public string? Ptstate { get; set; }

    public string? Ptzip { get; set; }

    public string? Countrycode { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Stopdate { get; set; }

    public long Mpixaddressnum { get; set; }
}
