using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Distributionsvcsetting
{
    public long? Tempcachenum { get; set; }

    public long? Maxretries { get; set; }

    public long? Flags { get; set; }

    public long Settingid { get; set; }

    public long? Maxrecips { get; set; }

    public string? Serveraddress { get; set; }

    public long? Portnum { get; set; }

    public string? Mailacctusername { get; set; }

    public string? Mailacctpassword { get; set; }

    public long? Encryptionversion { get; set; }

    public string? Emailuserpart { get; set; }

    public string? Domain { get; set; }

    public string? Emaildisplayname { get; set; }

    public long? Servertype { get; set; }

    public long? Emltransferencoding { get; set; }

    public long? Pollingperiod { get; set; }

    public string? Initvectordata { get; set; }
}
