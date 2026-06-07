using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bscsnapshothist
{
    public long? Bscsnapshotnum { get; set; }

    public long? Bscsnapshotdefnum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Usernum { get; set; }

    public long? Status { get; set; }
}
