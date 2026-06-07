using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpmediafile
{
    public long Mpmediafilenum { get; set; }

    public long? Mpmedianum { get; set; }

    public long? Itemnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Startitempagenum { get; set; }

    public long? Enditempagenum { get; set; }

    public long? Mediaformat { get; set; }

    public long? Mpcontenttype { get; set; }

    public long? Videobitratedef { get; set; }

    public long? Videowidth { get; set; }

    public long? Videoheight { get; set; }

    public long? Audiocodec { get; set; }

    public long? Audiocodeclevel { get; set; }

    public long? Audiobitrate { get; set; }

    public long? Audiobitspersample { get; set; }

    public long? Audiosamplespersec { get; set; }

    public long? Audiochannels { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Flags { get; set; }

    public long? Cleanupstatus { get; set; }

    public long? Revisionnum { get; set; }

    public long? Videolength { get; set; }
}
