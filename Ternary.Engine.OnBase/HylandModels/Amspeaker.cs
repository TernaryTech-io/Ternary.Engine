using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amspeaker
{
    public long Amspeakernum { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Middlename { get; set; }

    public string? Amspeakertitle { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Emailaddress { get; set; }

    public string? Ward { get; set; }

    public DateTime? Datecreated { get; set; }
}
