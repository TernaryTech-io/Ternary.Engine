using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailqueuerecip
{
    public long Emailqueuerecnum { get; set; }

    public long? Distrequestnum { get; set; }

    public long? Sequenceid { get; set; }

    public long? Recipienttype { get; set; }

    public string? Emaildisplayname { get; set; }

    public string? Emailuserpart { get; set; }

    public string? Domain { get; set; }

    public long? Flags { get; set; }

    public long? Status { get; set; }
}
