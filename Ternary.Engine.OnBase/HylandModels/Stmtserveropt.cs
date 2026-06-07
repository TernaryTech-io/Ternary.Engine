using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtserveropt
{
    public long? Faxretry { get; set; }

    public long? Faxduration { get; set; }

    public long? Faxtimeout { get; set; }

    public long? Notifyretry { get; set; }

    public long? Notifyduration { get; set; }

    public long? Emailretry { get; set; }

    public long? Emailduration { get; set; }

    public long? Distsourcekeynum { get; set; }

    public long? Stmtrecipkeynum { get; set; }

    public long? Autocdtrankeynum { get; set; }

    public long? Distrecorditnum { get; set; }

    public long? Distcddocitnum { get; set; }

    public long? Flags { get; set; }

    public long? Distnotifyitnum { get; set; }

    public long? Viewstatuskeynum { get; set; }

    public string? Emailfolder { get; set; }

    public string? Messengerurl { get; set; }
}
