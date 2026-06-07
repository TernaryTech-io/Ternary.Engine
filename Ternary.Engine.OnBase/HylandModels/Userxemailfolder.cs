using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userxemailfolder
{
    public long Usernum { get; set; }

    public long Emailfoldernum { get; set; }

    public long? Ownerusernum { get; set; }

    public long? Privs { get; set; }
}
