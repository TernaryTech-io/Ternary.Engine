using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Notificationlist
{
    public long Notilistnum { get; set; }

    public string? Notilistname { get; set; }

    public string? Notilisttext { get; set; }

    public string? Notilisthelp { get; set; }

    public long? Scope { get; set; }

    public string? Notilistlongtext { get; set; }

    public string? Noteseparator { get; set; }

    public string? Notelastseparator { get; set; }

    public long? Processscope { get; set; }

    public long? Flags { get; set; }

    public long? Itemnum { get; set; }

    public long? Notitype { get; set; }

    public long? Maxnotiversion { get; set; }

    public long? Itemtypenum { get; set; }
}
