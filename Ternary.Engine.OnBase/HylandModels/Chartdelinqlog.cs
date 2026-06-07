using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartdelinqlog
{
    public long Chtdfcynum { get; set; }

    public long? Chtnum { get; set; }

    public long? Physusernum { get; set; }

    public DateTime? Lastdatedelinq { get; set; }

    public long? Hoursdelinq { get; set; }

    public long? Isactivelydelinq { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Delinqlevel { get; set; }
}
