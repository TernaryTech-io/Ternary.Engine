using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Racroirequest
{
    public long? Roirequestnum { get; set; }

    public long? Roirecipientnum { get; set; }

    public string? Racrecordid { get; set; }

    public string? Racclaimnumber { get; set; }

    public string? Npinumber { get; set; }

    public long? Itemnum { get; set; }

    public string? Encryptedpassword { get; set; }

    public string? Racrecipientname { get; set; }

    public long? Racclaimid { get; set; }
}
