using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcstatexassignment
{
    public long Lcnum { get; set; }

    public long Statenum { get; set; }

    public long Assignmentnum { get; set; }

    public long Assignmenttype { get; set; }

    public long? Flags { get; set; }
}
