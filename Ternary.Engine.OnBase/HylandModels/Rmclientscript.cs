using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmclientscript
{
    public long Scriptid { get; set; }

    public string? Eventname { get; set; }

    public long? Fieldid { get; set; }

    public long? Scopetype { get; set; }

    public long? Screenid { get; set; }

    public string? Scripttext { get; set; }

    public long? Viewid { get; set; }
}
