using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Distributionhist
{
    public long? Distrequestnum { get; set; }

    public long? Requesttype { get; set; }

    public long? Requeststatus { get; set; }

    public DateTime? Completiondate { get; set; }

    public long? Usernum { get; set; }

    public long? Processingid { get; set; }

    public long? Retries { get; set; }

    public long? Itemnum { get; set; }
}
