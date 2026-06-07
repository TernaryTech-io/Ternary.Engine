using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirequestxrejection
{
    public long? Roirequestnum { get; set; }

    public long? Rejectreasonnum { get; set; }

    public string? Rejectreason { get; set; }

    public DateTime? Rejecteddate { get; set; }

    public long? Rejectusernum { get; set; }

    public long? Itemnum { get; set; }
}
