using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gisfoldertype
{
    public long? Foldertypenum { get; set; }

    public long? Gisconfiglayernum { get; set; }

    public long? Childfoldertypenum { get; set; }

    public string? Folderurllinkname { get; set; }

    public long Gisfoldertypesnum { get; set; }
}
