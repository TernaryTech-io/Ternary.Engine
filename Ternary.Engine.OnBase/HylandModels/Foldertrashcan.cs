using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldertrashcan
{
    public long Foldernum { get; set; }

    public string? Foldername { get; set; }

    public long? Usernum { get; set; }

    public string? Username { get; set; }

    public long? Foldertypenum { get; set; }

    public string? Foldertypename { get; set; }

    public DateTime? Datedeleted { get; set; }

    public long? Batchnum { get; set; }
}
