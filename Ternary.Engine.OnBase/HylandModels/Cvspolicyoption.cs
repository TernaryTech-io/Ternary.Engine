using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cvspolicyoption
{
    public long? Cvspolicynum { get; set; }

    public string? Optionname { get; set; }

    public long? Datatype { get; set; }

    public long? Intoption { get; set; }

    public DateTime? Dateoption { get; set; }

    public string? Charoption { get; set; }

    public string? Cvsdescription { get; set; }

    public long? Flags { get; set; }
}
