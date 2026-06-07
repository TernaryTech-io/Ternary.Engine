using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notificationkw
{
    public long Notilistnum { get; set; }

    public long Keytypenum { get; set; }

    public long? Mappingtype { get; set; }

    public string Propertyname { get; set; } = null!;

    public long Srckeytypenum { get; set; }

    public long? Flags { get; set; }
}
