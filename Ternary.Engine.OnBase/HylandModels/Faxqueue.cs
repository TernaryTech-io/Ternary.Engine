using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Faxqueue
{
    public long Distfaxnum { get; set; }

    public long? Distrequestnum { get; set; }

    public string? Recipname { get; set; }

    public string? Distsubject { get; set; }

    public string? Phonenumber { get; set; }

    public string? Attachments { get; set; }

    public long? Errorstatus { get; set; }

    public long? Faxhandle { get; set; }
}
