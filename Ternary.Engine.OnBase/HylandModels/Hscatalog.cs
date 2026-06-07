using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hscatalog
{
    public long Hscatalognum { get; set; }

    public string? Hscatalogname { get; set; }

    public long? Handlertype { get; set; }

    public long? Dataproviders { get; set; }

    public string? Catalogpath { get; set; }

    public long? Ftserverid { get; set; }

    public string? Friendlyname { get; set; }

    public string? Localpathforindexing { get; set; }

    public string? Description { get; set; }

    public long? Flags { get; set; }
}
