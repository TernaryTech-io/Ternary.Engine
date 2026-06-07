using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldereventhist
{
    public long? Foldernum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Eventexecuted { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Rimeventnum { get; set; }

    public DateTime? Eventeffectdate { get; set; }

    public long? Newfolderstatus { get; set; }

    public long? Foldereventnum { get; set; }
}
