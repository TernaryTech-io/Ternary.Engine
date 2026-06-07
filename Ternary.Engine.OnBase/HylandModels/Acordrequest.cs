using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Acordrequest
{
    public long? Acordservicenum { get; set; }

    public long? Driveritemnum { get; set; }

    public long? Requestitemnum { get; set; }

    public string? Transrefguid { get; set; }

    public long? Queuenum { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Flags { get; set; }

    public string? Reqinfoguid { get; set; }

    public long? Responseitemnum { get; set; }

    public long? Authrespcode { get; set; }

    public long? Respcode { get; set; }

    public long? Reqstatuscode { get; set; }

    public long? Reqstatussubcode { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Datereceived { get; set; }

    public long? Intstatuscode { get; set; }
}
