using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsnotify
{
    public long Imsnotifynum { get; set; }

    public string? Imsnotifyname { get; set; }

    public long? Lockboxnum { get; set; }

    public long? Itemtypenum { get; set; }

    public DateTime? Begindate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Notifyperiod { get; set; }

    public long? Notifyhour { get; set; }

    public long? Notifyminute { get; set; }

    public long? Notifytimezone { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastintervaldate { get; set; }

    public long? Externalusernum { get; set; }

    public string? Emailaddresslist { get; set; }

    public DateTime? Hitfromdate { get; set; }

    public DateTime? Hittodate { get; set; }
}
