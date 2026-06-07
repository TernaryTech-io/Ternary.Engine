using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailarchiveadmin
{
    public string? Emailrootpath { get; set; }

    public long? Emailminspace { get; set; }

    public long? Emailmaxhits { get; set; }

    public string? Licensenotify { get; set; }

    public long? Emailretperiod { get; set; }

    public long? Flags { get; set; }
}
