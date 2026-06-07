using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocessauditlog
{
    public long Bpmneventnum { get; set; }

    public long? Eventtype { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Approvalstatus { get; set; }

    public long? Approvervote { get; set; }

    public long? Flags { get; set; }
}
