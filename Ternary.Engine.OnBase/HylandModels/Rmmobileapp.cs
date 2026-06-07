using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmobileapp
{
    public long Mobileappid { get; set; }

    public string? Mobileappname { get; set; }

    public long? Rmapplicationid { get; set; }

    public long? Rmdescriptionid { get; set; }

    public long? Flags { get; set; }

    public string? Publishedhash { get; set; }
}
