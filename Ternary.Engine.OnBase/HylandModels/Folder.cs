using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Folder
{
    public long Foldernum { get; set; }

    public string? Foldername { get; set; }

    public long? Status { get; set; }

    public long? Batchnum { get; set; }

    public long? Parentfoldernum { get; set; }

    public DateTime? Foldercreatedate { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Numbernotes { get; set; }

    public long? Usernum { get; set; }

    public long? Eyesonly { get; set; }

    public long? Managedstatus { get; set; }

    public long? Reservedoc { get; set; }

    public long? Reservefolder { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Startdate { get; set; }

    public long? Sealed { get; set; }
}
