using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Check21log
{
    public long C21lognum { get; set; }

    public long Batchnum { get; set; }

    public long Pocketnum { get; set; }

    public string? Fullfilepath { get; set; }

    public DateTime? Processdate { get; set; }

    public long? Status { get; set; }

    public long? Usernum { get; set; }

    public decimal? Fileamount { get; set; }

    public string? Recipientaba { get; set; }

    public string? Senderaba { get; set; }

    public long? Fileidmodifer { get; set; }

    public long? Actiontype { get; set; }

    public long? Verifyitemnum { get; set; }
}
