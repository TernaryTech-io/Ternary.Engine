using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Faxconfig
{
    public long? Faxtype { get; set; }

    public string? Faxserveraddress { get; set; }

    public string? Faxusername { get; set; }

    public string? Faxpassword { get; set; }

    public string? Fcsname { get; set; }

    public string? Defaultsendname { get; set; }

    public string? Defaultfaxnum { get; set; }

    public string? Defaultvoicenum { get; set; }

    public string? Defaultoperatenum { get; set; }

    public string? Defaultgeneralnum { get; set; }

    public string? Billcode1 { get; set; }

    public string? Billcode2 { get; set; }

    public long? Flags { get; set; }
}
