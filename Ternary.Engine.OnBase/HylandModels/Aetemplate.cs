using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aetemplate
{
    public long Aetemplatenum { get; set; }

    public string? Description { get; set; }

    public long? Storagetemplatnum { get; set; }

    public long? Viewtemplatenum { get; set; }

    public long? Assigningauthoritynum { get; set; }

    public long? Vnasearchtmplnum { get; set; }

    public long? Flags { get; set; }

    public long? Vnarecontmplnum { get; set; }
}
