using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgmigratorjob
{
    public long Dgmigratorjobnum { get; set; }

    public string? Description { get; set; }

    public long? Destdiskgroupnum { get; set; }

    public long? Processabortthreshold { get; set; }

    public long? Fileabortthreshold { get; set; }

    public long? Status { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Lastprocessed { get; set; }

    public long? Flags { get; set; }

    public long? Usernum { get; set; }
}
