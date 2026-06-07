using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Searchspace
{
    public long Searchspacenum { get; set; }

    public string? Searchspacename { get; set; }

    public long? Creatorusernum { get; set; }

    public long? Ownerusernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public string? Veritypath { get; set; }

    public long? Spaceusedkbytes { get; set; }

    public long? Totalitems { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastupdate { get; set; }
}
