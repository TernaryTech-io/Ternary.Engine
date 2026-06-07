using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Deletedfile
{
    public long Deletedfilenum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datedeleted { get; set; }

    public string? Fullfilepath { get; set; }
}
