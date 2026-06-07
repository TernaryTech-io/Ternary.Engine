using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ssaccount
{
    public long Ssaccountnum { get; set; }

    public string? Ssaccountname { get; set; }

    public string? Serveraddress { get; set; }

    public long? Portnum { get; set; }

    public string? Mailacctusername { get; set; }

    public string? Mailacctpassword { get; set; }

    public long? Pollingperiod { get; set; }

    public long? Registernum { get; set; }

    public long? Flags { get; set; }

    public long? Institution { get; set; }

    public long? Accountstatus { get; set; }

    public string? Mailaccountpassword2 { get; set; }

    public string? Mailaccountpassword3 { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
