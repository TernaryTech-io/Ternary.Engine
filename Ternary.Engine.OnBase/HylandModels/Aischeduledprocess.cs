using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aischeduledprocess
{
    public long Aiprocessnum { get; set; }

    public string? Aiprocessname { get; set; }

    public long? Aiprocesstype { get; set; }

    public long? Schedtemplatenum { get; set; }

    public DateTime? Lastaiprocdatetime { get; set; }

    public long? Aiprocessupdate { get; set; }

    public long? Vbscriptnum { get; set; }

    public long? Flags { get; set; }

    public long? Weekday { get; set; }
}
