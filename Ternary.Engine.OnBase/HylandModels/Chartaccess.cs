using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartaccess
{
    public long? Usernum { get; set; }

    public DateTime? Accessexpiredate { get; set; }

    public long? Grantingusernum { get; set; }

    public DateTime? Granteddate { get; set; }

    public string? Grantoraccnote { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public long? Chtnum { get; set; }

    public long? Chtrequestnum { get; set; }

    public long? Emergencyaccess { get; set; }
}
