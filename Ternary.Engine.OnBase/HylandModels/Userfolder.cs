using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userfolder
{
    public long Userfoldernum { get; set; }

    public string? Userfoldername { get; set; }

    public long? Ownerusernum { get; set; }

    public long? Behalfusernum { get; set; }

    public long? Flags { get; set; }
}
