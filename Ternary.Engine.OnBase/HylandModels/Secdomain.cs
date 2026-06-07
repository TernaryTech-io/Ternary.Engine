using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Secdomain
{
    public long Secdomainnum { get; set; }

    public string? Secdomainname { get; set; }

    public string? Netbiosname { get; set; }

    public string? Domainsid { get; set; }

    public string? Altcreduser { get; set; }

    public string? Altcredpswd { get; set; }

    public long? Flags { get; set; }

    public string? Secdomainip { get; set; }

    public long? Pswdencrypttype { get; set; }

    public string? Initvectordata { get; set; }
}
