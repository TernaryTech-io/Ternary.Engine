using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medfacility
{
    public long Facilitynum { get; set; }

    public string? Facilityname { get; set; }

    public long? Activeperiod { get; set; }

    public string? Chtautoname { get; set; }

    public long? Delinqdays { get; set; }

    public long? Legalstatusdelay { get; set; }

    public long? Allowemergencyacc { get; set; }

    public string? Facilitynamehl7 { get; set; }

    public long? Requestdays { get; set; }

    public long? Flags { get; set; }

    public long? Securityflags { get; set; }

    public string? Termdigitmask { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Phonenumber { get; set; }

    public string? Faxnum { get; set; }
}
