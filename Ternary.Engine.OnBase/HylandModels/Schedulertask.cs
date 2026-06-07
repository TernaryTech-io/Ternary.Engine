using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedulertask
{
    public long Schedtasknum { get; set; }

    public string? Schedtaskname { get; set; }

    public string? Schedtaskdesc { get; set; }

    public long? Createduser { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Updateduser { get; set; }

    public DateTime? Updateddate { get; set; }

    public long? Schedtasktype { get; set; }

    public long? Schedtaskstatus { get; set; }

    public long? Workerpoolnum { get; set; }

    public DateTime? Effectivedatestart { get; set; }

    public DateTime? Effectivedateend { get; set; }

    public long? Execwindtemplnum { get; set; }

    public long? Flags { get; set; }

    public long? Utcoffsetmins { get; set; }

    public string? Tzidstring { get; set; }
}
