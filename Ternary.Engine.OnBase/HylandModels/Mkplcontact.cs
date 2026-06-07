using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplcontact
{
    public long Mkplcontactnum { get; set; }

    public long? Mkplprospectnum { get; set; }

    public string? Mkplcontactname { get; set; }

    public long? Contactmethod { get; set; }

    public string? Phonenumber { get; set; }

    public string? Faxnum { get; set; }

    public string? Emailaddress { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Contactother { get; set; }

    public long? Flags { get; set; }
}
