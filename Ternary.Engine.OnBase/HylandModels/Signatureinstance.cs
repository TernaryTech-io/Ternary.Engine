using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Signatureinstance
{
    public long Siginstnum { get; set; }

    public long? Docsiginstnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Usernum { get; set; }

    public long? Sigdefflags { get; set; }

    public long? Signaturetypenum { get; set; }

    public long? Hashtype { get; set; }

    public string? Sighash { get; set; }

    public string? Verifyconfig { get; set; }

    public long? Sigitemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }

    public DateTime? Sigdate { get; set; }

    public long? Sigdefnum { get; set; }
}
