using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptoschedrotation
{
    public long Keyrotationnum { get; set; }

    public long? Rotationtype { get; set; }

    public long? Keyprovidernum { get; set; }

    public long? Isolationid { get; set; }

    public string? Cryptokeyguid { get; set; }

    public DateTime? Rotationdate { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Status { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Flags { get; set; }

    public long? Rotationextent { get; set; }

    public long? Managedkeynum { get; set; }
}
