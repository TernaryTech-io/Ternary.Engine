using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmeventtype
{
    public long Eventtypeid { get; set; }

    public string? Eventdescription { get; set; }

    public long? Applicationid { get; set; }

    public long? Classid { get; set; }

    public long? Sequenceid { get; set; }

    public long? Flags { get; set; }
}
