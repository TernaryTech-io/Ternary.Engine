using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amcontactinfo
{
    public long Contactinfonum { get; set; }

    public long? Ammembernum { get; set; }

    public string? Contacttype { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Phonenumber { get; set; }

    public string? Mobilephone { get; set; }

    public string? Faxnum { get; set; }

    public string? Emailaddress { get; set; }
}
