using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ppocrconfig
{
    public string? Pollpath { get; set; }

    public string? Pollspec { get; set; }

    public string? Workpath { get; set; }

    public string? Outputpath { get; set; }

    public string? Successlog { get; set; }

    public string? Errorlogfile { get; set; }

    public string? Notifyemail { get; set; }

    public string? Backuppath { get; set; }

    public long? Blocksize { get; set; }

    public long? Architemtypenum { get; set; }

    public long? Configitemtypenum { get; set; }

    public long? Notifyflags { get; set; }

    public long? Ocrsettings { get; set; }

    public string? Processname { get; set; }

    public string? Excludechars { get; set; }
}
