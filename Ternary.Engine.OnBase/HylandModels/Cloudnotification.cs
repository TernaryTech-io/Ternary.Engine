using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cloudnotification
{
    public long? Notilistnum { get; set; }

    public long? Firstnotification { get; set; }

    public long? Recurringnotification { get; set; }

    public DateTime? Lastnotification { get; set; }

    public long? Flags { get; set; }
}
