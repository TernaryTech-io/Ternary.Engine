using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgencrmigrationjob
{
    public long Dgmigrationjobnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Iscompleted { get; set; }

    public long? Dgabortcode { get; set; }

    public long? Status { get; set; }

    public long? Analyzevalid { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Newlastuseddrive { get; set; }

    public string? Oldlastuseddrive { get; set; }

    public long? Flags { get; set; }

    public long? Reportitemnum { get; set; }
}
