using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mbufconfig
{
    public long Mobiledevicenum { get; set; }

    public long Ufconfignum { get; set; }

    public long? Ufconfigtype { get; set; }

    public long? Lastsynctimestamp { get; set; }

    public long? Flags { get; set; }
}
