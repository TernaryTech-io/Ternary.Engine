using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Editsession
{
    public long? Itemnum { get; set; }

    public string? Guid { get; set; }

    public long? Tempcacheitemnum { get; set; }

    public long? Usernum { get; set; }

    public long? Status { get; set; }

    public DateTime? Expirytime { get; set; }

    public long? Flags { get; set; }

    public string? Accesstoken { get; set; }

    public string? Wopilock { get; set; }

    public string? Xwopilock { get; set; }
}
