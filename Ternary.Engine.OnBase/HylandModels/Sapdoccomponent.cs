using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapdoccomponent
{
    public long Compnum { get; set; }

    public long? Archivelinkdocnum { get; set; }

    public string? Sapcompid { get; set; }

    public long? Itemnum { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Status { get; set; }

    public string? Contenttype { get; set; }

    public string? Charset { get; set; }

    public string? Version { get; set; }
}
