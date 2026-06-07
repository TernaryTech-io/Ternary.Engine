using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdocumentxuser
{
    public long Itemnum { get; set; }

    public long Docrevnum { get; set; }

    public long Usernum { get; set; }

    public DateTime? Dateadded { get; set; }

    public DateTime? Dateviewed { get; set; }

    public long? Flags { get; set; }

    public DateTime? Ackexpdate { get; set; }
}
