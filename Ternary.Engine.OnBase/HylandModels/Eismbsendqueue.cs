using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbsendqueue
{
    public long Eismsgnum { get; set; }

    public long? Eismsgtypenum { get; set; }

    public long? Status { get; set; }

    public long? Obobjecttype { get; set; }

    public long? Obobjectid { get; set; }

    public long? Requestblobnum { get; set; }

    public long? Responseblobnum { get; set; }

    public long? Eisclientnum { get; set; }

    public long? Batchnum { get; set; }

    public DateTime? Queuedts { get; set; }

    public DateTime? Checkedts { get; set; }

    public DateTime? Sentts { get; set; }

    public DateTime? Responsets { get; set; }

    public DateTime? Completedts { get; set; }

    public DateTime? Nextretryts { get; set; }

    public long? Retrycount { get; set; }

    public long? Flags { get; set; }

    public long? Usernum { get; set; }
}
