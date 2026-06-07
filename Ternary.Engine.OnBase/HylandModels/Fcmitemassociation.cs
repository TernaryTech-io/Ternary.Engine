using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmitemassociation
{
    public long Fcitemassocnnum { get; set; }

    public long? Fcassociatedtypeid1 { get; set; }

    public long? Fcassociatedid1 { get; set; }

    public long? Fcassociatedtypeid2 { get; set; }

    public long? Fcassociatedid2 { get; set; }

    public long? Flags { get; set; }

    public long? Usernum { get; set; }
}
