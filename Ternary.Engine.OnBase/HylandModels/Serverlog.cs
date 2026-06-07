using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Serverlog
{
    public long? Servertype { get; set; }

    public long? Registernum { get; set; }

    public long? Category { get; set; }

    public string? Messagetext { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Jobnum { get; set; }

    public long? Recipientnum { get; set; }

    public long? Flags { get; set; }
}
