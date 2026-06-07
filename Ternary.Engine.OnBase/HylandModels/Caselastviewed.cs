using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Caselastviewed
{
    public long Caselastviewednum { get; set; }

    public long? Caseinstancenum { get; set; }

    public long? Casetabnum { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagenum { get; set; }

    public DateTime? Dateviewed { get; set; }

    public DateTime? Dateexited { get; set; }

    public long? Caseusertabnum { get; set; }

    public long? Flags { get; set; }
}
