using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapdocument
{
    public long Archivelinkdocnum { get; set; }

    public string? Sapdocid { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Accessflags { get; set; }

    public long? Status { get; set; }

    public long? Repositorynum { get; set; }

    public long? Retentionactive { get; set; }
}
