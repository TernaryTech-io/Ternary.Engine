using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrsysnotification
{
    public long Mrsysnotifynum { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Notificationtext { get; set; }

    public long? Creatorusernum { get; set; }

    public long? Clientflags { get; set; }

    public string? Mrsysnotifyname { get; set; }

    public long? Notificationtype { get; set; }

    public string? Notificationurl { get; set; }
}
