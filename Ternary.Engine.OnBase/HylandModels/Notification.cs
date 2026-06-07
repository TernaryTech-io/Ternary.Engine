using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notification
{
    public long Keytypenum { get; set; }

    public long Usernum { get; set; }

    public long Usergroupnum { get; set; }

    public long Notilistnum { get; set; }

    public long? Flags { get; set; }

    public string? Email { get; set; }

    public long? Processingflag { get; set; }
}
