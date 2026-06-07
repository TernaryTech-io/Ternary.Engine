using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notificationlocale
{
    public long Lcid { get; set; }

    public long? Itemnum { get; set; }

    public string? Notilocalesubject { get; set; }

    public long? Flags { get; set; }

    public long Notivernum { get; set; }
}
