using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scheduledday
{
    public long Scheddaynum { get; set; }

    public long? Schedtemplatenum { get; set; }

    public long? Encodingtype { get; set; }

    public long? Value1 { get; set; }

    public long? Value2 { get; set; }

    public long? Value3 { get; set; }

    public long? Flags { get; set; }

    public long? Timemode { get; set; }

    public long? Schedstarttime { get; set; }

    public long? Schedendtime { get; set; }
}
