using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pswdpolicy
{
    public long Pswdpolicynum { get; set; }

    public long? Policytype { get; set; }

    public string? Policyname { get; set; }

    public string? Policydesc { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public long? Secquestionsetnum { get; set; }
}
