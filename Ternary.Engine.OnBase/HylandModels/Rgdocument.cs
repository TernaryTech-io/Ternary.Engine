using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdocument
{
    public long Rgdocumentnum { get; set; }

    public long? Readinggroupnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Documentstatus { get; set; }

    public long? Decisionstatus { get; set; }

    public DateTime? Decisiondate { get; set; }

    public DateTime? Dateactivated { get; set; }

    public DateTime? Datedeactivated { get; set; }

    public long? Submitusernum { get; set; }

    public long? Submitstatus { get; set; }

    public DateTime? Deadlinedate { get; set; }

    public DateTime? Availabledate { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Acklifetime { get; set; }

    public string? Admincomment { get; set; }

    public long? Tstestnum { get; set; }
}
