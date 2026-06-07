using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirequestextitem
{
    public long Roirequestnum { get; set; }

    public long Roiextitemnum { get; set; }

    public long? Roiquantity { get; set; }

    public decimal? Roicost { get; set; }

    public long? Clerkusernum { get; set; }
}
