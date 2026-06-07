using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmnotification
{
    public long Fcnotificationnum { get; set; }

    public long? Fcassociatedtypeid { get; set; }

    public long? Fcassociatedid { get; set; }

    public string? Fcfieldname { get; set; }

    public string? Fcvalue { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }
}
