using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tagstorage
{
    public long Tagstoragenum { get; set; }

    public long? Storagetemplatnum { get; set; }

    public long? Dicomtagnum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Flags { get; set; }

    public long? Parenttagnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Dicomtagvaluenum { get; set; }

    public long? Dicomlevel { get; set; }
}
