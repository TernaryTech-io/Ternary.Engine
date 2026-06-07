using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Systemlockout
{
    public long? Registernum { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public string? Lockoutmessage { get; set; }
}
