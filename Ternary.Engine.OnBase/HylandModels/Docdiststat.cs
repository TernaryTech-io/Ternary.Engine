using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docdiststat
{
    public long? Distributiontype { get; set; }

    public long? Institution { get; set; }

    public DateTime? Processdate { get; set; }

    public long? Totaldocuments { get; set; }
}
