using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usermail
{
    public long Usertonum { get; set; }

    public long Userfromnum { get; set; }

    public long Mailnum { get; set; }

    public long? Ack { get; set; }

    public long? Mailread { get; set; }

    public long? Deleteditem { get; set; }
}
