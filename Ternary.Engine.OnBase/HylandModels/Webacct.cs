using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Webacct
{
    public long Webacctnum { get; set; }

    public string? Webuserid { get; set; }

    public string? Webpassword { get; set; }

    public long? Acctstatus { get; set; }

    public string? Salutation { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Companyname { get; set; }

    public string? Title { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Stateabbr { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Defaultphone { get; set; }

    public string? Faxnum { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }
}
