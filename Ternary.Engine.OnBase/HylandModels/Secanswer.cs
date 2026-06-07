using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Secanswer
{
    public long Secanswernum { get; set; }

    public long? Usernum { get; set; }

    public string? Encryptedanswer { get; set; }

    public string? Sechint { get; set; }

    public long? Secquestionnum { get; set; }

    public long? Flags { get; set; }

    public long? Secencrypttype { get; set; }

    public string? Secsalt { get; set; }
}
