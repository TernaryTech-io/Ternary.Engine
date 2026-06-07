using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Physicalplatter
{
    public long Physicalplatternum { get; set; }

    public long Logicalplatternum { get; set; }

    public long Diskgroupnum { get; set; }

    public long? Plattertype { get; set; }

    public string? Diskidalias { get; set; }

    public string? Diskidfilename { get; set; }

    public long? Diskidflag { get; set; }

    public long? Diskidsize { get; set; }

    public string? Lastuseddrive { get; set; }

    public long? Spacefree { get; set; }

    public long? Spaceused { get; set; }

    public long? Disksearchorder { get; set; }

    public long? Blocksize { get; set; }

    public long? Maxcacheplatters { get; set; }

    public long? Platterdeleted { get; set; }

    public long? Onbackupqueue { get; set; }

    public long? Maxlogicalplatter { get; set; }

    public long? Minlogicalplatter { get; set; }

    public long? Dbnum { get; set; }

    public long? Plattercreated { get; set; }

    public long? Ondeletequeue { get; set; }

    public long? Plattertype2 { get; set; }

    public long? Storagesystem { get; set; }

    public long? S3bucketnum { get; set; }
}
