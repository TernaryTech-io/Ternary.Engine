using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wmauseroption
{
    public long Usernum { get; set; }

    public long Optiontype { get; set; }

    public long? Datatype { get; set; }

    public string? Optiondata { get; set; }
}
