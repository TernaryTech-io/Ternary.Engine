using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Passwordhistory
{
    public long Usernum { get; set; }

    public string Encryptedpassword { get; set; } = null!;

    public DateTime Datemodified { get; set; }

    public long? Pswdencrypttype { get; set; }

    public string? Initvectordata { get; set; }
}
