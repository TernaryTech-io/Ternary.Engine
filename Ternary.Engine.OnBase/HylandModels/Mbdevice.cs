using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mbdevice
{
    public long Mobiledevicenum { get; set; }

    public string? Deviceguid { get; set; }

    public long? Usernum { get; set; }

    public string? Userkey { get; set; }

    public string? Devicekey { get; set; }

    public string? Clientotp { get; set; }

    public string? Serverotphash { get; set; }

    public long? Userkeytimestamp { get; set; }

    public long? Serverotphashtime { get; set; }

    public long? Desiredwidth { get; set; }

    public long? Desiredheight { get; set; }

    public long? Flags { get; set; }

    public long? Lastsyncdate { get; set; }

    public string? Ufstaticversion { get; set; }

    public long? Deviceproperties { get; set; }

    public string? Restrictedkey { get; set; }
}
