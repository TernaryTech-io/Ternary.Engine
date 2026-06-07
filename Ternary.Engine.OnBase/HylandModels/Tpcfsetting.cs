using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfsetting
{
    public long? Flags { get; set; }

    public long? Failurethreshold { get; set; }

    public long? Daysuntilreprocess { get; set; }

    public long? Queueresettime { get; set; }

    public long? Itemsperqueue { get; set; }
}
