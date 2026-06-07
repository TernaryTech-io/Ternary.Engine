using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdocxuserhist
{
    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Dateadded { get; set; }

    public DateTime? Dateviewed { get; set; }

    public DateTime? Datereadded { get; set; }

    public long? Flags { get; set; }

    public long? Reasonflag { get; set; }
}
