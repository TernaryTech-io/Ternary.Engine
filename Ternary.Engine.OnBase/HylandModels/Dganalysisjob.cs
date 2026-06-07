using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dganalysisjob
{
    public long Dganalysisjobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Compphysplatnum { get; set; }

    public long? Usernum { get; set; }

    public long? Reportitemnum { get; set; }

    public long? Status { get; set; }

    public long? Priority { get; set; }

    public long? Dgresult { get; set; }

    public long? Flags { get; set; }
}
