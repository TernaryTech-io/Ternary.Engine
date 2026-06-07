using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbwkstemplate
{
    public long Wkstemplatenum { get; set; }

    public string? Wkstemplatename { get; set; }

    public string? Wksdescription { get; set; }

    public long? Defoptions { get; set; }

    public long? Wksrights { get; set; }

    public long? Docrights { get; set; }

    public long? Wvrights { get; set; }

    public long? Threadrights { get; set; }

    public long? Meetingrights { get; set; }

    public string? Welcomemsg { get; set; }
}
