using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmobjectsync
{
    public long Objectsyncid { get; set; }

    public long? Objectid { get; set; }

    public string? Synclastmodified { get; set; }

    public string? Syncobjectid { get; set; }
}
