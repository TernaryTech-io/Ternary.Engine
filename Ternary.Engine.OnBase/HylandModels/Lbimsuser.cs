using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsuser
{
    public long? Customernum { get; set; }

    public string? Externaluserid { get; set; }

    public string? Externalusername { get; set; }

    public string? Encryptedpassword { get; set; }

    public long? Flags { get; set; }

    public long Externalusernum { get; set; }

    public long? Disablelogin { get; set; }

    public long? Badlogincount { get; set; }

    public DateTime? Lastpwchange { get; set; }

    public DateTime? Lastlogon { get; set; }

    public string? Emailaddress { get; set; }

    public long? Status { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
