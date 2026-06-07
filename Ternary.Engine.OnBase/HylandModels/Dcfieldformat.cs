using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcfieldformat
{
    public long Dctemplatefldnum { get; set; }

    public long Dctemplatenum { get; set; }

    public long? Formattype { get; set; }

    public long? Destcurrfmtnum { get; set; }

    public long? Srccurrfmtnum { get; set; }

    public string? Destdateformat { get; set; }

    public string? Srcdateformat { get; set; }

    public long? Destmask { get; set; }

    public long? Srcmask { get; set; }

    public long? Fieldformatflags { get; set; }

    public long? Flags { get; set; }

    public long? Barcodeoutputtype { get; set; }

    public long? Barcodewidth { get; set; }

    public long? Barcodeheight { get; set; }

    public long? Barminbarwidth { get; set; }

    public long? Barminbarheigth { get; set; }
}
