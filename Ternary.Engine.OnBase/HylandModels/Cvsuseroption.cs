using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cvsuseroption
{
    public long? Usernum { get; set; }

    public string? Optionname { get; set; }

    public long? Datatype { get; set; }

    public long? Intoption { get; set; }

    public DateTime? Dateoption { get; set; }

    public string? Charoption { get; set; }
}
