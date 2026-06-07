using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Distributionqueue
{
    public long Distrequestnum { get; set; }

    public long? Requesttype { get; set; }

    public long? Processingid { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Usernum { get; set; }

    public long? Obblobnum { get; set; }

    public long? Retries { get; set; }

    public long? Requeststatus { get; set; }

    public long? Itemnum { get; set; }
}
