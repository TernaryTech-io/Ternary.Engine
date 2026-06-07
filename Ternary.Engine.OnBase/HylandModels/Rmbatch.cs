using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmbatch
{
    public long? Rmbatchid { get; set; }

    public string? Batchname { get; set; }

    public long? Status { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Numberdocuments { get; set; }

    public long? Verifyitemnum { get; set; }

    public long? Flags { get; set; }
}
