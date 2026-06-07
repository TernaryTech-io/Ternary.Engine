using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnapendingchange
{
    public long Vnapendingchgnum { get; set; }

    public long? Vnaaccessnum { get; set; }

    public long? Vnastudynum { get; set; }

    public long? Vnarevnum { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Studyinstanceuid { get; set; }

    public string? Studyhash { get; set; }
}
