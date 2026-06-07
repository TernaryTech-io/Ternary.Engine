using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmnotification
{
    public long Notificationid { get; set; }

    public long? Deliveryflags { get; set; }

    public string? Rmdescription { get; set; }

    public long? Iterationflags { get; set; }

    public long? Longevitytype { get; set; }

    public string? Rmname { get; set; }

    public long? Notificationflags { get; set; }

    public long? Notificationtype { get; set; }

    public string? Outputcontenttype { get; set; }

    public long? Outputformat { get; set; }

    public long? Outputmergemode { get; set; }

    public long? Ownerobjectid { get; set; }

    public long? Ownerobjecttype { get; set; }

    public string? Parameters { get; set; }

    public string? Rmrecipients { get; set; }

    public long? Testid { get; set; }

    public long? Testop { get; set; }

    public long? Testtype { get; set; }

    public string? Testvalue { get; set; }

    public long? Templateresourceid { get; set; }
}
