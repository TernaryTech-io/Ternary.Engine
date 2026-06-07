using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amagendadoclog
{
    public long Agendadoclognum { get; set; }

    public DateTime? Datestored { get; set; }

    public long? Docgentype { get; set; }

    public long? Itemnum { get; set; }

    public long? Ammeetingnum { get; set; }
}
