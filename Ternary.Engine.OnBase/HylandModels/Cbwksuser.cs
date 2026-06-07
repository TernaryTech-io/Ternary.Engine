using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbwksuser
{
    public long Workspacenum { get; set; }

    public long Usernum { get; set; }

    public long? Wksrights { get; set; }

    public long? Docrights { get; set; }

    public long? Wvrights { get; set; }

    public long? Threadrights { get; set; }

    public long? Wksoptions { get; set; }

    public long? Meetingrights { get; set; }
}
