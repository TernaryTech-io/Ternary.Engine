using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapilmlegalhold
{
    public long Archivelinkdocnum { get; set; }

    public string Sapdocid { get; set; } = null!;

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }

    public string Legalcase { get; set; } = null!;

    public long? Legalholdstatus { get; set; }
}
