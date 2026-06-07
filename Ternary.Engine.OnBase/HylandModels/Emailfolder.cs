using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailfolder
{
    public long Emailfoldernum { get; set; }

    public string? Emailfoldername { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Creatorusernum { get; set; }
}
