using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notificationversion
{
    public long Notivernum { get; set; }

    public long? Notilistnum { get; set; }

    public long? Notiversion { get; set; }

    public long? Flags { get; set; }

    public string? Vercomment { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Lastmodified { get; set; }
}
