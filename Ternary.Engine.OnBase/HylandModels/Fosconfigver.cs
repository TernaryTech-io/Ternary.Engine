using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fosconfigver
{
    public long Fosconfignum { get; set; }

    public long Fosconfigversion { get; set; }

    public long? Obblobnum { get; set; }

    public long? Createdusernum { get; set; }

    public DateTime? Createddate { get; set; }
}
