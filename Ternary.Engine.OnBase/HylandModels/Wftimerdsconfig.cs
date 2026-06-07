using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wftimerdsconfig
{
    public long Wftimerdsnum { get; set; }

    public string? Odbcname { get; set; }

    public string? Domain { get; set; }

    public string? Wfmachinename { get; set; }

    public long? Institution { get; set; }

    public long? Versionnum { get; set; }

    public long? Updatedisplayafter { get; set; }

    public long? Bpmnintervaltype { get; set; }

    public long? Bpmninterval { get; set; }

    public long? Flags { get; set; }
}
