using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbworkspace
{
    public long Workspacenum { get; set; }

    public string? Workspacename { get; set; }

    public string? Wksdescription { get; set; }

    public long? Wksoptions { get; set; }

    public long? Wkstemplatenum { get; set; }

    public long? Wksowner { get; set; }

    public DateTime? Creationdate { get; set; }

    public long? Active { get; set; }

    public long? Wksrights { get; set; }

    public long? Docrights { get; set; }

    public long? Wvrights { get; set; }

    public long? Threadrights { get; set; }

    public long? Meetingrights { get; set; }

    public string? Welcomemsg { get; set; }
}
