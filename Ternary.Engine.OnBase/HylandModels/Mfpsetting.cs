using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfpsetting
{
    public string? Mfpftpusername { get; set; }

    public string? Mfpftppasswd { get; set; }

    public string? Ftpurl { get; set; }

    public long? Flags { get; set; }
}
