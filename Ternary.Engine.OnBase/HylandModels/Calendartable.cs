using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Calendartable
{
    public DateTime? Outagedate { get; set; }

    public string? Outagereason { get; set; }

    public long? Nonholiday { get; set; }
}
