using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Coreaccesstoken
{
    public string? Accesstoken { get; set; }

    public DateTime? Expirationtime { get; set; }

    public string? Contextdata { get; set; }

    public long? Coretokentype { get; set; }

    public long? Coretokenflags { get; set; }

    public long? Usernum { get; set; }

    public string? Contextblob { get; set; }

    public string? Authtokenid { get; set; }
}
