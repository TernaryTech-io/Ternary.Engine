using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Useraccountmail
{
    public long Usernum { get; set; }

    public string? Postoffice { get; set; }

    public string? Maillogin { get; set; }

    public string? Mailpassword { get; set; }

    public string? Mailaccount { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }
}
