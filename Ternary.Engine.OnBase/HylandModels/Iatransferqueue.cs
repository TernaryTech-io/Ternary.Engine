using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iatransferqueue
{
    public long Batchnum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Numberdocs { get; set; }

    public long? Requesterusernum { get; set; }

    public long? Transfertype { get; set; }

    public long? Workstationnum { get; set; }

    public long? Remotebatchnum { get; set; }

    public long? Remotehsinum { get; set; }

    public string? Localiaid { get; set; }

    public long? Status { get; set; }

    public DateTime? Reqstartdate { get; set; }

    public DateTime? Reqenddate { get; set; }

    public long? Iatype { get; set; }

    public long? Flags { get; set; }
}
