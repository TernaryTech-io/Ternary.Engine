using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dicomtag
{
    public long Dicomtagnum { get; set; }

    public string? Dicomtagname { get; set; }

    public long? Dicomtaggroup { get; set; }

    public long? Dicomtagelement { get; set; }

    public long? Dicomtagcomponent { get; set; }

    public long? Dicomlevel { get; set; }

    public long? Defaulttagstorage { get; set; }

    public long? Flags { get; set; }

    public long? Dicomtagvaluetype { get; set; }
}
