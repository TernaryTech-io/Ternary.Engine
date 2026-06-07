using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmconstraintset
{
    public long Constraintsetid { get; set; }

    public string? Rmname { get; set; }

    public long? Classid { get; set; }

    public string? Rmdescription { get; set; }

    public long? Bgrouplikeconstraints { get; set; }

    public long? Flags { get; set; }
}
