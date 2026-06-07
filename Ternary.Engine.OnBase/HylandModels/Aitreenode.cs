using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aitreenode
{
    public long Aitreenodenum { get; set; }

    public long? Aitreenum { get; set; }

    public long? Parentnodenum { get; set; }

    public long? Nodeindex { get; set; }

    public long? Totalweight { get; set; }

    public long? Testfeaturenum { get; set; }

    public long? Testfeaturevalue { get; set; }

    public long? Otherweight { get; set; }

    public long? Outputvalue { get; set; }
}
