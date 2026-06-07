using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obimportconfig
{
    public long? Pswdpolicynum { get; set; }

    public long? Maxpackagesize { get; set; }

    public long? Flags { get; set; }

    public string? Externalfiledir { get; set; }
}
