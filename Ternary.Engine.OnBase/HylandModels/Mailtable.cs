using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mailtable
{
    public long Mailnum { get; set; }

    public string? Mailtext { get; set; }

    public string? Subject { get; set; }

    public long? Candelete { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Eyesonly { get; set; }

    public long? Foldernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Mailitemnum { get; set; }

    public long? Status { get; set; }

    public long? Usernum { get; set; }

    public string? Mailmessagetext { get; set; }

    public long? Mailflags { get; set; }
}
