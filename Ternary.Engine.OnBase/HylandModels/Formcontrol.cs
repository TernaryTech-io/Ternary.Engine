using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Formcontrol
{
    public long Frmctlnum { get; set; }

    public long? Controltype { get; set; }

    public long? Ctlsizex { get; set; }

    public long? Ctlsizey { get; set; }

    public string? Fontfacename { get; set; }

    public long? Pointsize { get; set; }

    public long? Linespace { get; set; }

    public long? Flags { get; set; }

    public long? Extrainfo1 { get; set; }
}
