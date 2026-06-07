using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfevent
{
    public long Wfeventnum { get; set; }

    public long? Wfeventsource { get; set; }

    public long? Wfeventcategory { get; set; }

    public long? Wfcontenttype { get; set; }

    public string? Wfeventname { get; set; }

    public long? Tasklistnum { get; set; }

    public long? Scopetype { get; set; }

    public long? Scope { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
