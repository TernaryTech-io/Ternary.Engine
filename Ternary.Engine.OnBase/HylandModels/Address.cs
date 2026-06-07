using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Address
{
    public long Addressnum { get; set; }

    public string? Vrstate { get; set; }

    public string? Vrcity { get; set; }

    public long? Housenumber { get; set; }

    public long? Apartmentnumber { get; set; }

    public string? Lotnumber { get; set; }

    public long? Streetnum { get; set; }

    public string? Zipcode { get; set; }

    public string? Vrcountry { get; set; }

    public string? Countrypostalcode { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Carrierroutecode { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Address5 { get; set; }

    public long? Addressflags { get; set; }
}
