using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbmeetattendee
{
    public long Attendeenum { get; set; }

    public long? Schedmeetnum { get; set; }

    public long? Externaluser { get; set; }

    public long? Usernum { get; set; }

    public string? Attendname { get; set; }

    public string? Emailaddress { get; set; }
}
