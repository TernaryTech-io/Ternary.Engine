using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obgsyscommenttype
{
    public long Syscommenttypenum { get; set; }

    public long? Obgsyscmntcategory { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public string? Description { get; set; }

    public string? Caption { get; set; }

    public long? Customcommenttype { get; set; }
}
