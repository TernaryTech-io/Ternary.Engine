using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Multipartuploadpart
{
    public long Id { get; set; }

    public long Multipartuploadid { get; set; }

    public int Partnum { get; set; }

    public virtual Multipartupload Multipartupload { get; set; } = null!;
}
