using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Micrparsedqueue
{
    public long Institution { get; set; }

    public long Micrbatchnum { get; set; }

    public long? Status { get; set; }

    public DateTime? Micrimportdate { get; set; }

    public long? Numunmatcheditems { get; set; }
}
