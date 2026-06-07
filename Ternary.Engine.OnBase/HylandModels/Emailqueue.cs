using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailqueue
{
    public long? Distrequestnum { get; set; }

    public string? Recipients1 { get; set; }

    public string? Recipients2 { get; set; }

    public string? Recipients3 { get; set; }

    public string? Distsubject { get; set; }

    public string? Attachments { get; set; }

    public string? Body { get; set; }

    public string? Sender { get; set; }

    public long? Flags { get; set; }

    public long? Priority { get; set; }
}
