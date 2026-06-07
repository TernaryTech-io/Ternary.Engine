using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmmoduleassociation
{
    public long Moduleassocid { get; set; }

    public long? Rmmoduletype { get; set; }

    public string? Rmname { get; set; }

    public long? Sequenceid { get; set; }

    public long? Rmobjecttype { get; set; }

    public long? Rmobjectkey { get; set; }

    public string? Rmdescription { get; set; }

    public long? Flags { get; set; }
}
