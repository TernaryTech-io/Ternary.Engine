using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailmessage
{
    public long Emailnum { get; set; }

    public long? Sendernum { get; set; }

    public string? Messageid1 { get; set; }

    public string? Messageid2 { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Archived { get; set; }

    public string? Emailsubject { get; set; }

    public string? Emailfilepath { get; set; }

    public long? Storagenum { get; set; }
}
