using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpcredential
{
    public long Mpcredentialnum { get; set; }

    public string? Mpauthname { get; set; }

    public string? Mpauthpassword { get; set; }

    public string? Mpinitvector { get; set; }

    public long? Pswdencrypttype { get; set; }
}
