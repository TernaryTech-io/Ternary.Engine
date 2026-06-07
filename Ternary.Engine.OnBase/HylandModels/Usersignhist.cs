using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usersignhist
{
    public long Usernum { get; set; }

    public long Sigusagecount { get; set; }

    public string? Storythread { get; set; }

    public DateTime? Sigtimestamp { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagenum { get; set; }

    public string? Sigtoken { get; set; }

    public long? Sigwidth { get; set; }

    public long? Sigheight { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Signflag { get; set; }

    public string? Certname { get; set; }

    public long? Originx { get; set; }

    public long? Originy { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Seqnum { get; set; }
}
