using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocessversion
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Approvalstatus { get; set; }

    public DateTime? Lastupdated { get; set; }

    public long? Usernum { get; set; }

    public long? Approvalruletype { get; set; }

    public long? Approvalruletimer { get; set; }

    public long? Approvalexpires { get; set; }

    public long? Publicnotifnum { get; set; }

    public long? Approvenotifnum { get; set; }

    public long? Rejectnotifnum { get; set; }

    public long? Expirednotifnum { get; set; }

    public long? Flags { get; set; }

    public long? Audittimer { get; set; }

    public long? Auditnotifnum { get; set; }

    public long? Stylenum { get; set; }
}
